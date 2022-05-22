using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TTS_Project
    {
    class Program
        {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TextToSpeechUI());
            
            TextToSpeech tts = new TextToSpeech();
            Locale l = new Locale();
            l.LanguageLong = "English";
            l.CountryLong = "india";
            IEnumerable<Voice> i;
            i = tts.GetVoices(l, false);
            Debug.Assert(i != null);
                foreach (Voice v in i)
                {
                Console.WriteLine(v.Name);
                }
            byte[] sound = null;
            Random r = new Random();
            Voice voice = i.ElementAt(r.Next(i.Count()));
            string s = "hello, my name is " + voice.Name;

            sound = tts.GetAudioBytes(voice, s, AudioFileType.wav, true);

            using (MemoryStream ms = new MemoryStream(sound))
                {
                SoundPlayer player = new SoundPlayer(ms);
                player.Play();
                }

            /*
                __atssc = google % 3B4

                ASP.NET_SessionId = mdej5jldhuwbt4thtllzzgai

                __atuvc = 1 % 7C39 % 2C3 % 7C40 % 2C11 % 7C41
                            __atuvs = 5f7f6ab660263b53001*/
            }
        }
    }
