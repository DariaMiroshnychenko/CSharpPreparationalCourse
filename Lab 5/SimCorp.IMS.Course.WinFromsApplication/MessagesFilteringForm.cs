using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimCorp.IMS.Course.Formatter;
using static SimCorp.IMS.Course.Filter;
using static SimCorp.IMS.Course.Message;
using static SimCorp.IMS.Course.MessageStorage;
using System.Collections.Concurrent;

namespace SimCorp.IMS.Course.WinFromsApplication
{ 
    public partial class MessageFilteringFrom : Form
    {
        private delegate void GeneratingMessagesInvoker(int maxNumberOfMessages);

        List<Message> messages { get; set; } = new List<Message>();
        List<int> filteredMessageIds = new List<int>();
        HashSet<string> uniqueMessageSenders = new HashSet<string>();
        SimCorpMobile SimCorpMobile { get; set; }
        Battery Battery { get; set; }
        static object StateLock { get; set; } = new object();

        public MessageFilteringFrom()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            List<Message> filteredMessages = FilterMessages();
            SetFilteredMessageIds(filteredMessages);
            filteredMessages = FormatFilteredMessages();
            ShowMessages(filteredMessages);
        }

        private List<Message> FilterMessages()
        {
            Dictionary<FilteringOptions, bool> selectedFilteringOptions = new Dictionary<FilteringOptions, bool>();
            Dictionary<FilteringOptions, IEnumerable<Message>> filteredEnumerables = new Dictionary<FilteringOptions, IEnumerable<Message>>();

            bool senderIsSpecified = senderComboBox.SelectedItem != null;
            bool textToLookForIsSpecified = lookForTextBox.Text.Any();
            bool timeRangeIsSpecified = (fromDateTimePicker.Value != fromDateTimePicker.MinDate || toDateTimePicker.Value != toDateTimePicker.MinDate);
            bool someFilteringIsSpecified = senderIsSpecified || textToLookForIsSpecified || timeRangeIsSpecified;

            IEnumerable<Message> messagesBySender = FilterBySender(selectedFilteringOptions, filteredEnumerables, senderIsSpecified);
            IEnumerable<Message> messagesByContainingText = FilterByContainingText(selectedFilteringOptions, filteredEnumerables, textToLookForIsSpecified);
            IEnumerable<Message> messagesByTimeRange = FilterByRecievingTime(selectedFilteringOptions, filteredEnumerables, timeRangeIsSpecified);

            IEnumerable<Message> filteringQuery;
            if (someFilteringIsSpecified)
            {
                filteringQuery = Filter.ApplyAndOrLogic(messages, selectedFilteringOptions, filteredEnumerables, andRadioButton.Checked, orRadioButton.Checked);
            }
            else
            {
                filteringQuery = messages.Select(m => m);
                MessageBox.Show("No filtering is specified.", "Info");
            }

            List<Message> filteredMessages = filteringQuery.OrderBy(m => m.RecievingTime).ToList();

            return filteredMessages;
        }

        private IEnumerable<Message> FilterBySender(Dictionary<FilteringOptions, bool> selectedFilteringOptions, Dictionary<FilteringOptions, IEnumerable<Message>> filteredEnumerables, bool senderIsSpecified)
        {
            IEnumerable<Message> messagesBySender = messages.Select(m => m);

            selectedFilteringOptions.Add(FilteringOptions.BySender, senderIsSpecified);
            if (selectedFilteringOptions[FilteringOptions.BySender])
            {
                messagesBySender = Filter.FilterBySender(messages, senderComboBox.SelectedItem.ToString());
            }
            filteredEnumerables.Add(FilteringOptions.BySender, messagesBySender);

            return messagesBySender;
        }

        private IEnumerable<Message> FilterByContainingText(Dictionary<FilteringOptions, bool> selectedFilteringOptions, Dictionary<FilteringOptions, IEnumerable<Message>> filteredEnumerables, bool textToLookForIsSpecified)
        {
            IEnumerable<Message> messagesByContainingText = messages.Select(m => m);

            selectedFilteringOptions.Add(FilteringOptions.ByContainingText, textToLookForIsSpecified);
            if (selectedFilteringOptions[FilteringOptions.ByContainingText])
            {
                messagesByContainingText = Filter.FilterByContainingText(messages, lookForTextBox.Text);
            }
            filteredEnumerables.Add(FilteringOptions.ByContainingText, messagesByContainingText);

            return messagesByContainingText;
        }

        private IEnumerable<Message> FilterByRecievingTime(Dictionary<FilteringOptions, bool> selectedFilteringOptions, Dictionary<FilteringOptions, IEnumerable<Message>> filteredEnumerables, bool timeRangeIsSpecified)
        {
            IEnumerable<Message> messagesByRecievingTime = messages.Select(m => m);

            selectedFilteringOptions.Add(FilteringOptions.ByDate, timeRangeIsSpecified);
            if (selectedFilteringOptions[FilteringOptions.ByDate])
            {
                messagesByRecievingTime = Filter.FilterByRecievingTime(messages, fromDateTimePicker.Value, toDateTimePicker.Value);
            }
            filteredEnumerables.Add(FilteringOptions.ByDate, messagesByRecievingTime);

            return messagesByRecievingTime;
        }

        private void SetFilteredMessageIds(List<Message> filteredMessages)
        {
            filteredMessageIds = filteredMessages.Select(m => m.MessageId).ToList();
        }

        private void MessageFilteringFrom_Load(object sender, EventArgs e)
        {
            batteryChargeProgressBar.Value = 10;
            threadApproachRadioButton.Checked = true;

            this.FormClosed += new FormClosedEventHandler(MessageFilteringFrom_FormClosed);
        }

        private void MessageFilteringFrom_FormClosed(object sender, EventArgs e)
        {
            Battery?.StopOngoingChargingProcesses();
        }


        private void SetRemainingChargeOfBattery()
        {
            Battery.RemainingChargeInPercent = batteryChargeProgressBar.Value;
        }

        private void SetBasicPropertiesForDatePickers(int numberOfMessages)
        { 
            toDateTimePicker.MaxDate = DateTime.Today;
            fromDateTimePicker.MaxDate = DateTime.Today;
            toDateTimePicker.MinDate = DateTime.Today.AddDays(-numberOfMessages);
            fromDateTimePicker.MinDate = DateTime.Today.AddDays(-numberOfMessages);
            toDateTimePicker.Value = toDateTimePicker.MinDate;
            fromDateTimePicker.Value = fromDateTimePicker.MinDate;
        }

        private void OnMessageIsAdded(Message message)
        {
            if (messagesListView.InvokeRequired)
            {
                var AddingMessageEventHandler = new AddingMessageEventHandler(OnMessageIsAdded);
                this.BeginInvoke(AddingMessageEventHandler, message);
            }
            else
            {
                var FormattingEventHandler = new FormattingHandler(OnFormatting);
                message.Text = FormattingEventHandler?.Invoke(message);

                messages.Add(message);
                filteredMessageIds.Add(message.MessageId);
                PutUniqueSendersToComboBox(message.PhoneNumber);

                Action<Message> AddNewMessageToView = m => messagesListView.Items.Add(new ListViewItem(new[] { m.PhoneNumber, m.Text }));
                messagesListView.Invoke(AddNewMessageToView, message);
            }
        }

        private void PutUniqueSendersToComboBox(string senderPhoneNumber)
        {
            if (!uniqueMessageSenders.Contains(senderPhoneNumber))
            {
                uniqueMessageSenders.Add(senderPhoneNumber);
                senderComboBox.Items.Add(senderPhoneNumber);
            }
        }

        private void ShowMessages(List<Message> messages)
        {
            messagesListView.Items.Clear();

            if (messages.Any())
            {
                foreach (var message in messages)
                {
                    messagesListView.Items.Add(new ListViewItem(new[] { message.PhoneNumber, message.Text }));
                }
            }
            else
            {
                MessageBox.Show("There are no messages sutisfying selected filtering.", "Info");
            }
        }

        private string OnFormatting(Message message)
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

        private void formattingOptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Message> formattedMessages = FormatFilteredMessages();
            ShowMessages(formattedMessages);
        }

        private List<Message> FormatFilteredMessages()
        {
            var FormattingEventHandler = new FormattingHandler(OnFormatting);
            List<Message> formattedMessages = new List<Message>();

            for (int i = 0; i < filteredMessageIds.Count; i++)
            {
                Message messageToFormat = messages.Single(m => m.MessageId == filteredMessageIds[i]);
                formattedMessages.Add(new Course.Message(messageToFormat.MessageId,
                                                         messageToFormat.PhoneNumber,
                                                         messageToFormat.Text,
                                                         messageToFormat.RecievingTime));
                formattedMessages[i].Text = FormattingEventHandler?.Invoke(formattedMessages[i]);
            }

            return formattedMessages;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetFiltering();
            List<Message> formattedMessages = FormatFilteredMessages();
            ShowMessages(formattedMessages);
        }

        private void ResetFiltering()
        {
            senderComboBox.SelectedItem = null;
            lookForTextBox.Text = "";
            fromDateTimePicker.Value = fromDateTimePicker.MinDate;
            toDateTimePicker.Value = toDateTimePicker.MinDate;
            andRadioButton.Checked = false;
            orRadioButton.Checked = true;
            SetFilteredMessageIds(messages);
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckDates();
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AlignToDate();
            CheckDates();
        }

        private void AlignToDate()
        {
            if (toDateTimePicker.Value == toDateTimePicker.MinDate)
            {
                toDateTimePicker.Value = fromDateTimePicker.Value;
            }
        }

        private void CheckDates()
        {
            try
            {
                if (fromDateTimePicker.Value > toDateTimePicker.Value)
                {
                    throw new ArgumentException("'From Date' must be earlier that 'To Date'.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int numberOfMessages = 50;
            SetBasicPropertiesForDatePickers(numberOfMessages);

            SMSProvider smsProvider = GetSMSProvider();
            smsProvider.Timer = new RealTimer();

            SimCorpMobile = new SimCorpMobile(smsProvider);
            MessageStorage messageStorage = new MessageStorage();
            Formatter formatter = new Formatter();

            SimCorpMobile.MessageStorage = messageStorage;
            messageStorage.MessageIsAdded += OnMessageIsAdded;
            formatter.Formatting += OnFormatting;

            ClearPreviousMessageListData();

            GeneratingMessagesInvoker GeneratingMessagesInvoker = new GeneratingMessagesInvoker(SimCorpMobile.StartGenerateMessages);
            GeneratingMessagesInvoker?.Invoke(numberOfMessages);
        }

        private void ClearPreviousMessageListData()
        {
            messages = new List<Message>();
            uniqueMessageSenders = new HashSet<string>();
            senderComboBox.Items.Clear();
            messagesListView.Items.Clear();
            ResetFiltering();
        }

        private SMSProvider GetSMSProvider()
        {
            SMSProviderFactory smsProviderFactory;
            if (threadApproachRadioButton.Checked)
            {
                smsProviderFactory = new SMSProviderBasedOnThreadsFactory();
            }
            else
            {
                smsProviderFactory = new SMSProviderBasedOnTasksFactory();
            }

            return smsProviderFactory.GetSMSProvider();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            SimCorpMobile.StopGenerateMessages();
        }

        private void chargeButton_Click(object sender, EventArgs e)
        {
            Battery.ProcessSwitchingOfChargingState();
        }

        public void OnRemainingChargeChanged(int currentPercent)
        {
            Action<int> DisplayCurrentChargePercent = cp => batteryChargeProgressBar.Value = cp;
            lock(StateLock)
            {
                batteryChargeProgressBar.Invoke(DisplayCurrentChargePercent, currentPercent);
            } 
        }

        private void threadApproachRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (threadApproachRadioButton.Checked)
            {
                ApproachChanged();
            }
        }

        private void taskApproachRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (taskApproachRadioButton.Checked)
            {
                ApproachChanged();
            }
        }

        private void ApproachChanged()
        {
            Battery?.StopOngoingChargingProcesses();

            BatteryFactory batteryFactory;
            if (taskApproachRadioButton.Checked)
            {
                batteryFactory = new BatteryBasedOnTasksFactory();
            }
            else 
            {
                batteryFactory = new BatteryBasedOnThreadsFactory();
            }

            Battery = batteryFactory.GetBattery();
            Battery.Timer = new RealTimer();
            Battery.RemainingChargeChanged += OnRemainingChargeChanged;
            SetRemainingChargeOfBattery();
            Battery.Discharge();
        }
    }
}
