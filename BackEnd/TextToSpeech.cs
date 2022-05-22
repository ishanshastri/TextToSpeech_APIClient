using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TTS_Project
    {
    /// <summary>
    /// Class that contains API's for text to speech conversion using VoiceRSS
    /// </summary>
    class TextToSpeech
        {
        private static string AppFolderName = "TTS_Audio_Files";
        private static string Referer = "http://www.voicerss.org/api/demo.aspx";
        private static string UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36";
        public TextToSpeech()
            {
            CreateAppFolder();
            }
        /// <summary>
        /// Gets the voices.
        /// </summary>
        /// <param name="locale">The locale.</param>
        /// <param name="isMale">if set to <c>true</c> [is male].</param>
        /// <returns>The collection of available voices</returns>
        public IEnumerable<Voice> GetVoices(Locale locale = null, bool isMale = false)
            {
            List<Voice> voices = new List<Voice>();
            IEnumerable<Locale> allLocales = GetAllLocales();
            bool useLabel = false;
            IEnumerable<Voice> localeVoices = null;
            if(locale.Label != string.Empty)
                {
                useLabel = true;
                }

            foreach(Locale l in allLocales)//Loop through all locales and compare labels (or country and language (long and shorthand))
                {
                if (useLabel)
                    {
                    if (l.Label == locale.Label)
                        {
                        localeVoices = l.Voices;
                        break;
                        }
                    }
                else
                    {
                    if((l.CountryShort.ToLower() == locale.CountryShort.ToLower() && l.LanguageShort.ToLower() == locale.LanguageShort.ToLower()) || 
                        l.CountryLong.ToLower() == locale.CountryLong.ToLower() && l.LanguageLong.ToLower() == locale.LanguageLong.ToLower())
                        {
                        localeVoices = l.Voices;
                        break;
                        }
                    }
                }
            foreach(Voice v in localeVoices)
                {
                if(v.IsMale == isMale)
                    {
                    voices.Add(v);
                    }
                }
            return (IEnumerable<Voice>)voices;
            }

        public IEnumerable<Voice> GetAllVoices()
            {
            IEnumerable<Voice> localeVoices = new List<Voice>();
            IEnumerable<Locale> allLocales = GetAllLocales();
            List<Voice> resultList = new List<Voice>();

            foreach(Locale l in allLocales)
                {
                localeVoices = l.Voices;
                foreach(Voice v in localeVoices)
                    {
                    resultList.Add(v);
                    }
                }
            return (IEnumerable<Voice>)resultList;
            }
        /// <summary>
        /// Gets the TTS audio.
        /// </summary>
        /// <param name="voice">The voice name.</param>
        /// <param name="text">The text to be converted to speech.</param>
        /// <param name="fileType">The return file format.</param>
        /// <param name="save">Whether caller wishes to save audio file.</param>
        /// <param name="audioFileName">The name of the file to save audio.</param>
        /// <returns>TTS audio file</returns>
        public byte[] GetAudioBytes(Voice voice, string text, AudioFileType fileType, bool save = false, string audioFileName = "TTS_Audio")
            {
            // Create URL
            string urlEncodedText = HttpUtility.UrlEncode(text);
            string randomValue = GetRandomIntegerString(18);
            string url = GetUrl(voice, urlEncodedText, fileType, randomValue);

            // Create request, and get response
            HttpWebResponse httpResponse = (HttpWebResponse)GetHttpWebRequest(url).GetResponse();// (HttpWebResponse)httpWebRequest.GetResponse();
            var bytes = default(byte[]);
            using (var memstream = new MemoryStream())
                {
                httpResponse.GetResponseStream().CopyTo(memstream);
                bytes = memstream.ToArray();
                }
            //Save if caller wishes to save audio file
            if (save)
                {
                SaveAudioFile(audioFileName + "." + fileType.ToString(), bytes);
                }
            return bytes;
            }

        /// <summary>
        /// Gets the HTTP web request.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>The HttpWebRequest with correct credentials</returns>
        private HttpWebRequest GetHttpWebRequest(string url)
            {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Referer = TextToSpeech.Referer;
            httpWebRequest.UserAgent = TextToSpeech.UserAgent;

            return httpWebRequest;
            }

        /// <summary>
        /// Gets all voices.
        /// </summary>
        /// <returns>Collection of voices on webpage</returns>
        private IEnumerable<Locale> GetAllLocales()
            {
            List<string> voices = new List<string>();
            string htmlText = GetHtml();
            int headerIndex = htmlText.IndexOf("Select language and voice");
            string labelText = "label=\"";
            string valueText = "value=\"";
            int startIndex = 0;
            string interimText = htmlText.Substring(headerIndex, htmlText.Length - headerIndex - 1);
            string label = string.Empty;
            string languageCountry = string.Empty;
            string name = string.Empty;
            string gender = string.Empty;
            int separatorIndex = 0;
            int checkIndex = 0;
            Voice voice = new Voice();
            Locale locale = new Locale();
            List<Locale> locales = new List<Locale>();

            //Loop through different language labels
            while (!(locale.Label.ToLower().Contains("vietnam")))
                {
                //Extract label tag
                startIndex = interimText.IndexOf(labelText) + labelText.Length;
                interimText = interimText.Substring(startIndex, interimText.Length - startIndex - 1);
                locale = new Locale();
                label = interimText.Substring(0, interimText.IndexOf("\""));
                locale.Label = label;
                separatorIndex = label.IndexOf("(");
                
                if(separatorIndex > 1)//Ensure that the longhand country is provided in label (sometimes this is not the case)
                    {
                    locale.LanguageLong = label.Substring(0, separatorIndex - 1);
                    locale.CountryLong = label.Substring(separatorIndex + 1, label.IndexOf(")") - separatorIndex - 1);
                    }
                else//If there is no longhand country, then the language is the same as the label
                    {
                    locale.CountryLong = label;
                    }
                //Loop through each voice under label
                while (!(voice.Name.ToLower().Contains("chi")))
                    {
                    voice = new Voice();
                    //Extract language and country tag
                    startIndex = interimText.IndexOf(valueText) + valueText.Length;
                    //Perform check to ensure that the next value of interest is not a label (otherwise break to continue outer loop)
                    checkIndex = interimText.IndexOf(labelText);
                    if(checkIndex != -1 && startIndex > checkIndex)
                        {
                        break;
                        }
                    interimText = interimText.Substring(startIndex, interimText.Length - startIndex - 1);
                    separatorIndex = interimText.IndexOf(":");
                    languageCountry = interimText.Substring(0, separatorIndex);
                    voice.LanguageShort = languageCountry.Substring(0, 2);                   
                    voice.CountryShort = languageCountry.Substring(3, 2);
                    //Extract name 
                    startIndex = separatorIndex + 1;
                    interimText = interimText.Substring(startIndex, interimText.Length - startIndex - 1);
                    voice.Name = interimText.Substring(0, interimText.IndexOf("\""));
                    //Extract gender
                    startIndex = interimText.IndexOf("(") + 1;
                    interimText = interimText.Substring(startIndex, interimText.Length - startIndex - 1);
                    gender = interimText.Substring(0, interimText.IndexOf(")"));
                    if (gender.ToLower() == "male")//If gender is male, then set isMale to true (otherwise it remains false)
                        {
                        voice.IsMale = true;
                        }
                    locale.AddToVoices(voice);                    
                    }
                if(locale.Voices.Count() > 0)
                    {
                    Voice v = locale.Voices.ElementAt(0);
                    locale.CountryShort = v.CountryShort;
                    locale.LanguageShort = v.LanguageShort;
                    }
                locales.Add(locale);               
                }
            return (IEnumerable<Locale>)locales;
            }
        
        /// <summary>
        /// Gets the HTML.
        /// </summary>
        /// <returns>Returns html text</returns>
        private string GetHtml()
            {
            try
                {
                WebClient wc = new WebClient();
                return wc.DownloadString(Referer);
                }
            catch
                {
                return null;
                }
            }

        /// <summary>
        /// Saves the audio file.
        /// </summary>
        /// <param name="FileNameShort">The file name (short; without entire path).</param>
        /// <param name="bytes">The bytes.</param>
        private void SaveAudioFile(string FileNameShort, byte[] bytes)
            {
            string soundFilename = Path.Combine(GetFolderDirectory(), FileNameShort);
            File.WriteAllBytes(soundFilename, bytes);
            }

        /// <summary>
        /// Gets the random integer string.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns>string of random integers</returns>
        private string GetRandomIntegerString(int length)
            {
            string randomValue = string.Empty;
            Random r = new Random();
            for (int i = 0; (i < length); i++)
                {
                int digit = r.Next(9) + 1;
                randomValue += digit.ToString();
                }
            return randomValue;
            }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <param name="voice">The voice.</param>
        /// <param name="urlEncodedText">The URL encoded text.</param>
        /// <param name="fileType">Type of the file.</param>
        /// <param name="randomValue">The random value.</param>
        /// <returns>The URL with correct inputs</returns>
        private static string GetUrl(Voice voice, string urlEncodedText, AudioFileType fileType, string randomValue)
            {
            string languageCountry = (voice.LanguageShort + "-" + voice.CountryShort);
            return string.Format("http://www.voicerss.org/controls/speech.ashx?hl={0}&v={1}&src={2}&c={3}&rnd=0.{4}", languageCountry, voice.Name, urlEncodedText, fileType.ToString(), randomValue);
            }

        /// <summary>
        /// Gets the folder directory.
        /// </summary>
        /// <returns></returns>
        private static string GetFolderDirectory()
            {
            string myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(myDocumentsFolder, AppFolderName);
            }

        /// <summary>
        /// Creates the application folder.
        /// </summary>
        private static void CreateAppFolder()
            {
            string folderName = GetFolderDirectory();
            if (!Directory.Exists(folderName))//Check if folder exists. If not, then create it.
                {
                Directory.CreateDirectory(folderName);
                }
            }
        }
    }
