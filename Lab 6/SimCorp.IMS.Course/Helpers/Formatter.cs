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

        public delegate string FormattingHandler(Message message);
        public event FormattingHandler Formatting = new FormattingHandler(NoFormatting);

        public string OnFormatting(Message message)
        {
            return InvokeFromatting(Formatting, message);
        }

        private string InvokeFromatting(FormattingHandler formattingHandler, Message message)
        {
            return formattingHandler?.Invoke(message);
        }

        public static string NoFormatting(Message message)
        {
            return message.Text;
        }

        public static string StartWithDateTimeFormat(Message message)
        {
            return $"[{message.RecievingTime}] {message.Text}";
        }
        public static string EndWithDateTimeFormat(Message message)
        {
            return $"{message.Text} [{message.RecievingTime}]";
        }
        public static string LowerCaseFormat(Message message)
        {
            return message.Text.ToLower();
        }

        public static string UpperCaseFormat(Message message)
        {
            return message.Text.ToUpper();
        }

        public static string EndWithMessageLengthFormat(Message message)
        {
            return $"{message.Text} ({message.Text.Length} symbols)";
        }
    }
}
