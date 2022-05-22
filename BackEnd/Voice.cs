using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTS_Project
    {
    /// <summary>
    /// Class that represents a voice with gender and name
    /// </summary>
    class Voice
        {
        public string Name { get; set; }
        public string CountryShort { get; set; }
        public string LanguageShort { get; set; }
        public bool IsMale { get; set; }
        //Consider variable LanguageCountry for use with this API

        public Voice()
            {
            this.Name = string.Empty;
            this.CountryShort = string.Empty;
            this.LanguageShort = string.Empty;
            this.IsMale = false;
            }
        }
    }
