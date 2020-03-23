using SimCorp.IMS.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimCorp.IMS.Course.SMSProvider;
using static SimCorp.IMS.Course.Formatter;

namespace SimCorp.IMS.Course.WinFormsApplication
{
    public partial class MessagesForm : Form
    {
        private delegate void StartGeneratingMessagesInvoker(int maxNumberOfMessages);

        public MessagesForm()
        {
            InitializeComponent();
        }

        private void MessagesForm_Load(object sender, EventArgs e)
        {
            int maxNumberOfMessages = 30;
            formattingOptionsComboBox.SelectedIndex = (int)FormattingOptions.None;

            SMSProvider smsProvider = new SMSProvider();
            smsProvider.SMSReceived += OnSMSRecieved;

            Formatter formatter = new Formatter();
            formatter.Formatting += OnFormatting;

            StartGeneratingMessagesInvoker StartGeneratingMessagesInvoker = new StartGeneratingMessagesInvoker(smsProvider.GenerateMessages);
            StartGeneratingMessagesInvoker.BeginInvoke(maxNumberOfMessages, null, null);
        }

        private void OnSMSRecieved(string message)
        {
            if (messagesRichTextBox.InvokeRequired)
            {
                var SMSReceivedEventHandler = new SMSReceivedHandler(OnSMSRecieved);
                this.BeginInvoke(SMSReceivedEventHandler, message);
            }
            else
            {
                var FormattingEventHandler = new FormattingHandler(OnFormatting);
                string formattedMessage = FormattingEventHandler?.Invoke(message);

                this.messagesRichTextBox.AppendText($"{formattedMessage}{Environment.NewLine}");
            }
        }

        private string OnFormatting(string message)
        {
            FormattingHandler Formatting = new FormattingHandler(NoFormatting);

            switch ((FormattingOptions)formattingOptionsComboBox.SelectedIndex)
            {
                case FormattingOptions.None:
                    Formatting = new FormattingHandler(NoFormatting);
                    break;
                case FormattingOptions.StartWithDateTime:
                    Formatting = new FormattingHandler(StartWithDateTimeFormat);
                    break;
                case FormattingOptions.EndWithDateTime:
                    Formatting = new FormattingHandler(EndWithDateTimeFormat);
                    break;
                case FormattingOptions.LowerCase:
                    Formatting = new FormattingHandler(LowerCaseFormat);
                    break;
                case FormattingOptions.UpperCase:
                    Formatting = new FormattingHandler(UpperCaseFormat);
                    break;
                case FormattingOptions.EndWithMessageLength:
                    Formatting = new FormattingHandler(EndWithMessageLengthFormat);
                    break;
            }

            return Formatting(message);
        }
    }
}
