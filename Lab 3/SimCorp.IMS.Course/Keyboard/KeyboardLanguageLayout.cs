using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class KeyboardLanguageLayout
    {
        public string LanguageShortCode { get; set; }
        public char[] Letters { get; set; }

        public KeyboardLanguageLayout() : this(languageShortCode: "EN",
                                               letters: "abcdefghijklmnopqrstuvwxyz".ToCharArray())
        {

        }

        public KeyboardLanguageLayout(string languageShortCode, char[] letters)
        {
            this.LanguageShortCode = languageShortCode;
            this.Letters = letters;
        }
    }
}
