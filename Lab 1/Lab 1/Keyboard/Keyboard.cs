using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Keyboard
    {
        public enum KeypadTypes
        {
            QWERTY,
            LetterEase,
            FLpK,
            LessTap,
            EQ3,
            Fastap
        }
        public KeypadTypes Type { get; set; }
        public readonly int[] Numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public List<KeyboardLanguageLayout> LanguageLayouts { get; set; }
        public char[] Symbols { get; set; }

        public Keyboard() : this(keypadType: KeypadTypes.QWERTY, 
                                 keyboardLanguageLayouts: new List<KeyboardLanguageLayout> { new KeyboardLanguageLayout() }, 
                                 symbols: "*#.,!?".ToCharArray())
        {

        }

        public Keyboard(KeypadTypes keypadType, List<KeyboardLanguageLayout> keyboardLanguageLayouts, char[] symbols)
        {
            this.Type = keypadType;
            this.LanguageLayouts = keyboardLanguageLayouts;
            this.Symbols = symbols;
        }

        public override string ToString()
        {
            string languageCodes = "";
            foreach (KeyboardLanguageLayout layout in LanguageLayouts)
            {
                languageCodes += layout.LanguageShortCode + " ";
            }

            return Type +  " keyboard with " + languageCodes + "language layout(s) present";
        }
    }
}
