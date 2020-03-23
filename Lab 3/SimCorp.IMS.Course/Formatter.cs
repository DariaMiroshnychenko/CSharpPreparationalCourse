using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class Formatter
    { 
        public enum FormattingOptions
        {
            None,
            StartWithDateTime,
            EndWithDateTime,
            LowerCase,
            UpperCase,
            EndWithMessageLength
        }

        public delegate string FormattingHandler(string message);
        public event FormattingHandler Formatting = new FormattingHandler(NoFormatting);

        public string OnFormatting(string message)
        {
            return InvokeFromatting(Formatting, message);
        }

        private string InvokeFromatting(FormattingHandler formattingHandler, string message)
        {
            return formattingHandler?.Invoke(message);
        }

        public static string NoFormatting(string message)
        {
            return message;
        }

        public static string StartWithDateTimeFormat(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }
        public static string EndWithDateTimeFormat(string message)
        {
            return $"{message} [{DateTime.Now}]";
        }
        public static string LowerCaseFormat(string message)
        {
            return message.ToLower();
        }

        public static string UpperCaseFormat(string message)
        {
            return message.ToUpper();
        }

        public static string EndWithMessageLengthFormat(string message)
        {
            return $"{message} ({message.Length} symbols)";
        }
    }
}
