using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTS_Project
    {
    /// <summary>
    /// Class to identify language, country and list of available voices for a specific locale
    /// </summary>
    class Locale
        {
        /// <summary>
        /// The voices (private list)
        /// </summary>
        private List<Voice> voices;

        public Locale()
            {
            voices = new List<Voice>();
            Label = string.Empty;
            CountryLong = string.Empty;
            LanguageLong = string.Empty;
            CountryShort = string.Empty;
            LanguageShort = string.Empty;
            }

        /// <summary>
        /// Gets or sets the name (name as given by VoiceRSS for use in combobox).
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the language (shorthand).
        /// </summary>
        /// <value>
        /// The language (shorthand).
        /// </value>
        public string LanguageShort { get; set; }

        /// <summary>
        /// Gets or sets the country (shorthand).
        /// </summary>
        /// <value>
        /// The country name in shorthand.
        /// </value>
        public string CountryShort { get; set; }

        /// <summary>
        /// Gets or sets the country (longhand).
        /// </summary>
        /// <value>
        /// The country name in longand.
        /// </value>
        public string CountryLong { get; set; }

        /// <summary>
        /// Gets or sets the language (longhand).
        /// </summary>
        /// <value>
        /// The language (longhand).
        /// </value>
        public string LanguageLong { get; set; }

        /// <summary>
        /// Gets the voices.
        /// </summary>
        /// <value>
        /// The voices.
        /// </value>
        public IEnumerable<Voice> Voices
            {
            get { return (IEnumerable<Voice>)voices; }
            }

        /// <summary>
        /// Adds to voices.
        /// </summary>
        /// <param name="voice">The voice.</param>
        public void AddToVoices(Voice voice)
            {
            this.voices.Add(voice);
            }
        }
    }
