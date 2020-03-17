using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimCorp.IMS.Course.PlaybackHandler;
using static SimCorp.IMS.Course.ChargerHandler;
using static SimCorp.IMS.Course.SimCardHandler;
using static SimCorp.IMS.Course.StorageHandler;
using static SimCorp.IMS.Course.PhoneComponentsHandler;

namespace SimCorp.IMS.Course.WinFormsApplication
{
    public partial class SelectAndRunComponentForm : Form
    {
        public SelectAndRunComponentForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (playbackComponentRadioButton.Checked)
            {
                PlaybackHandler playbackHandler = new PlaybackHandler(new RichTextBoxOutput(componentTypeMenuRichTextBox));
                playbackHandler.ShowMenuOfPlaybackComponents();
            }

            if (chargerRadioButton.Checked)
            {
                ChargerHandler chargerHandler = new ChargerHandler(new RichTextBoxOutput(componentTypeMenuRichTextBox));
                chargerHandler.ShowMenuOfChargerComponents();
            }

            if (removableStorageRadioButton.Checked)
            { 
                StorageHandler storageHandler = new StorageHandler(new RichTextBoxOutput(componentTypeMenuRichTextBox));
                storageHandler.ShowMenuOfStorages();
            }

            if (simCardRadioButton.Checked)
            {
                SimCardHandler simCardHandler = new SimCardHandler(new RichTextBoxOutput(componentTypeMenuRichTextBox));
                simCardHandler.ShowMenuOfSimCards();
            }

            chosenComponentTypeIndex.Text = "";
            outputOfSettingAndRunningComponentRichTextBox.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chosenComponentTypeIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            bool userHasSelectedComponentType = playbackComponentRadioButton.Checked || chargerRadioButton.Checked || removableStorageRadioButton.Checked || simCardRadioButton.Checked;

            if (userHasSelectedComponentType)
            {
                RichTextBoxOutput RichTextBoxOutput = new RichTextBoxOutput(outputOfSettingAndRunningComponentRichTextBox);
                TextBoxInput TextBoxInput = new TextBoxInput(chosenComponentTypeIndex);

                SimCorpMobile simCorpMobile = new SimCorpMobile(RichTextBoxOutput);
                PhoneComponentsHandler phoneComponentsHandler = new PhoneComponentsHandler(output: RichTextBoxOutput, input: TextBoxInput);

                if (playbackComponentRadioButton.Checked)
                {
                    phoneComponentsHandler.GetAndProcessUserSelectionOfPlayback(simCorpMobile);
                }

                if (chargerRadioButton.Checked)
                {
                    phoneComponentsHandler.GetAndProcessUserSelectionOfCharger(simCorpMobile);
                }

                if (removableStorageRadioButton.Checked)
                {
                    phoneComponentsHandler.GetAndProcessUserSelectionOfStorage(simCorpMobile);
                }

                if (simCardRadioButton.Checked)
                {
                    phoneComponentsHandler.GetAndProcessUserSelectionOfSimCard(simCorpMobile);
                }
            }
        }
    }
}
