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
using static SimCorp.IMS.Course.CallGenerator;

namespace SimCorp.IMS.Course.WinFormsApplication
{
    public partial class CallsForm : Form
    {
        SortedSet<Call> callSingleList { get; set; } = new SortedSet<Call>();
        SortedSet<Call> callGroupList { get; set; } = new SortedSet<Call>();

        public CallsForm()
        {
            InitializeComponent();
        }

        private void MessagesForm_Load(object sender, EventArgs e)
        {
            singleViewRadioButton.Checked = true;
        }

        private void ShowCalls()
        {
            callsListView.Items.Clear();

            if (singleViewRadioButton.Checked)
            {
                UpdateCallListView(callSingleList, CreateCallListViewItemSingle);
            }

            if (groupViewRadioButton.Checked)
            {
                UpdateCallListView(callGroupList, CreateCallListViewItemGroup);
            }
        }

        public void UpdateCallListView(SortedSet<Call> callsList, Func<Call, ListViewItem> createCallListViewItemMethod)
        {
            foreach (Call call in callsList)
            {
                var callItem = createCallListViewItemMethod(call);
                callsListView.Items.Add(callItem);
            }
        }

        private static ListViewItem CreateCallListViewItemGroup(Call call)
        {
            string contactInfo = call.Contact.Name;
            if (call.LinkedCalls.Any())
            {
                contactInfo += $" ({call.LinkedCalls.Count + 1})";
            }

            var callItem = new ListViewItem(new string[] { contactInfo,
                                                           call.CallDirection.ToString(),
                                                           call.CallTime.ToString(),
                                                           call.PhoneNumber,
                                                           call.CallDuration.ToString()});
            callItem.Tag = call;

            return callItem;
        }

        private void OnCallGenerated(Call call)
        {
            callSingleList.Add(call);
            AddCallToGroupList(call);
        }

        private void AddCallToGroupList(Call call)
        {
            if (!callGroupList.Any())
            {
                callGroupList.Add(call);
                return;
            }

            if (callGroupList.First().Equals(call))
            {
                call.LinkedCalls.Add(callGroupList.First());
                foreach (Call linkedCall in callGroupList.First().LinkedCalls)
                {
                    call.LinkedCalls.Add(linkedCall);
                }
                callGroupList.First().LinkedCalls.Clear();
                callGroupList.Remove(callGroupList.First());
                callGroupList.Add(call);
            }
            else
            {
                callGroupList.Add(call);
            }
        }

        private void groupViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (groupViewRadioButton.Checked)
            {
                ShowCalls();
                ShowInstructionMessageForGroupView();
            }
        }

        private void ShowInstructionMessageForGroupView()
        {
            if (callGroupList.Any())
            {
                MessageBox.Show("Select a call to see linked items.", "Info");
            }
        }

        private void singleViewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (singleViewRadioButton.Checked)
            {
                ShowCalls();
            }
        }

        private void callsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (callsListView.SelectedItems.Count == 0)
            {
                return;
            }

            if (groupViewRadioButton.Checked)
            {
                Call selectedCall = (Call)callsListView.SelectedItems[0].Tag;

                if (!selectedCall.LinkedCalls.Any())
                {
                    MessageBox.Show("There are no calls linked to the selected one.", "Info");
                    return;
                }

                ShowLinkedCallsOnNewForm(selectedCall);
            }
        }

        private static void ShowLinkedCallsOnNewForm(Call selectedCall)
        {
            LinkedCallsForm formWithLinkedCalls = new LinkedCallsForm();

            ListViewItem selectedCallItem = CreateCallListViewItemSingle(selectedCall);
            formWithLinkedCalls.linkedCallsListView.Items.Add(selectedCallItem);

            foreach (Call linkedCall in selectedCall.LinkedCalls)
            {
                ListViewItem linkedCallItem = CreateCallListViewItemSingle(linkedCall);
                formWithLinkedCalls.linkedCallsListView.Items.Add(linkedCallItem);
            }

            formWithLinkedCalls.ShowDialog();
        }

        private static ListViewItem CreateCallListViewItemSingle(Call call)
        {
            var callItem = new ListViewItem(new string[] { call.Contact.Name,
                                                           call.CallDirection.ToString(),
                                                           call.CallTime.ToString(),
                                                           call.PhoneNumber,
                                                           call.CallDuration.ToString()});
            return callItem;
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            int numberOfCalls = 200;

            callSingleList.Clear();
            callGroupList.Clear();

            CallGenerator callGenerator = new CallGenerator();
            callGenerator.CallGenerated += OnCallGenerated;

            await callGenerator.GenerateCalls(numberOfCalls);

            ShowCalls();

            if (groupViewRadioButton.Checked)
            {
                ShowInstructionMessageForGroupView();
            }
        }
    }
}
