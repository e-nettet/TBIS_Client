using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using HentRestgaeld.ServiceReferenceTBIS;

namespace HentRestgaeld
{
    public enum Miljoe { Test, Produktion}
    public partial class FormHentData : Form
    {
        private List<Part> partList;
        private ValidatePartyResponse validatePartyResponse;
        private string partID;
        private string modtagerPartID;
        private string password;
        private Miljoe miljoe;
        private string realkreditinstitut;
        private string pantidentifikation;
        private string laanenummer;
        private string kontrolkode;
        private string query;
        private TransactionReponse transactionResponse;
        string outputpath;
        string inputpath;

        public FormHentData()
        {
            InitializeComponent();
            this.Text = this.ProductName + " (version " + this.ProductVersion + ")";
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            comboBoxMiljoe.DataSource = Enum.GetValues(typeof(Miljoe));
            EnableButtons(true);
        }

        private void EnableButtons(Boolean enable)
        {
            if (enable)
            {
                buttonNext.Enabled = wizardTabcontrol1.SelectedIndex < wizardTabcontrol1.TabCount - 1;
                buttonTilbage.Enabled = wizardTabcontrol1.SelectedIndex > 0;
            }
            else
            {
                buttonNext.Enabled = false;
                buttonTilbage.Enabled = false;
            }
        }

        private void SetMessage(string message)
        {
            toolStripStatusLabel1.Text = message.Substring(0,  Math.Min(message.Length, 100));
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            switch (wizardTabcontrol1.SelectedIndex)
            {
                case 0:
                    {
                        partID = textBoxPartID.Text;
                        password = textBoxPassword.Text;
                        if (!backgroundWorkerValidateParty.IsBusy) { backgroundWorkerValidateParty.RunWorkerAsync(); }
                        break;
                    }
                case 1:
                    {
                        realkreditinstitut = partList[comboBoxRealkreditinstitut.SelectedIndex].beskrivelse;
                        pantidentifikation = textBoxPantnummer.Text;
                        laanenummer  = textBoxLaanenummer.Text;
                        kontrolkode = textBoxKontrolkode.Text;
                        modtagerPartID = GetSelectedPartID();
                        FRestgaeld6_Type f = RESTGAELD_Utils.GetFRestgaeld6_Type(modtagerPartID, pantidentifikation, kontrolkode, Kodeliste4.NOR, laanenummer);
                        query = RESTGAELD_Utils.GetClassAsXMLString(f);
                        if (!backgroundWorkerHentRestgaeld.IsBusy) { backgroundWorkerHentRestgaeld.RunWorkerAsync(); }
                    }
                    break;
                case 2:break;
                default: break;
            }
        }

        private string GetEndpointAddress()
        {
            string s;
            switch (miljoe)
            {
                case Miljoe.Produktion:
                    s = "https://tbisws.e-nettet.dk/TBISWS/Main";
                    break;
                case Miljoe.Test:
                    s = "https://test-tbisws.e-nettet.dk/TBISWS/Main";
                    break;

                default:
                    s = "";
                    break;
            }
            return (s);
        }

        private MainClient GetMainClient()
        {
            MainClient client = new MainClient();
            System.ServiceModel.EndpointAddress addr = new System.ServiceModel.EndpointAddress(GetEndpointAddress());
            client.Endpoint.Address = addr;
            return (client);
        }

        private ValidatePartyResponse GetValidatePartyResponse()
        {
            ServiceReferenceTBIS.MainClient client = GetMainClient();
            ValidatePartyResponse response = client.validateParty(partID, password);
            return (response);
        }

        private TransactionReponse GetTransactionResponse()
        {
            ServiceReferenceTBIS.MainClient client = GetMainClient();
            TransactionReponse response = client.doTransaction(partID, password, "F [rkn] Restgaeld 6 XML", modtagerPartID, query);
            return (response);
        }

        private void ButtonTilbage_Click(object sender, EventArgs e)
        {
            wizardTabcontrol1.SelectedIndex -= 1;
            EnableButtons(true);
        }


        private string GetSelectedPartID()
        {
            string s = partList[comboBoxRealkreditinstitut.SelectedIndex].partid;
            return (s);
        }

        private void BackgroundWorkerValidateParty_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerValidateParty.ReportProgress(0, "Validerer partid og password");
            try
            {
                validatePartyResponse = GetValidatePartyResponse();
                backgroundWorkerValidateParty.ReportProgress(0, validatePartyResponse.backEndStatusText);
            }
            catch (Exception f) { backgroundWorkerValidateParty.ReportProgress(0, f.Message); }
        }

        private void BackgroundWorkerValidateParty_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (validatePartyResponse.backEndStatusCode == 0)
                {
                    wizardTabcontrol1.SelectedIndex += 1;
                }
            }
            finally
            {
                EnableButtons(true);
            }
        }

        private void ComboBoxMiljoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            miljoe = (Miljoe)comboBoxMiljoe.SelectedIndex;
            comboBoxRealkreditinstitut.Items.Clear();
            partList = Part.getPartList(miljoe);
            for (int i = 0; i < partList.Count; i++)
            {
                comboBoxRealkreditinstitut.Items.Add(partList[i].beskrivelse);
            }
        }

        private void BackgroundWorkerValidateParty_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();
        }

        private void BackgroundWorkerHentRestgaeld_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerHentRestgaeld.ReportProgress(0, "Henter restgæld");
            try
            {
                inputpath = FileUtils.SaveToTempAndReturnFilepath(query);
                transactionResponse = GetTransactionResponse();
                backgroundWorkerHentRestgaeld.ReportProgress(0, transactionResponse.backEndStatusText);
            }
            catch (Exception f) { backgroundWorkerHentRestgaeld.ReportProgress(0, f.Message); }
        }

        private void BackgroundWorkerHentRestgaeld_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();
        }

        private void BackgroundWorkerHentRestgaeld_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (transactionResponse.backEndStatusCode == 0) 
                outputpath = FileUtils.SaveToTempAndReturnFilepath(transactionResponse.resultString);
                linkLabelInput.Links.Clear();
                linkLabelOutput.Links.Clear(); 
                linkLabelInput.Links.Add(0, linkLabelInput.Text.Length , inputpath);
                linkLabelOutput.Links.Add(0, linkLabelOutput.Text.Length, outputpath);
                wizardTabcontrol1.SelectedIndex += 1;
            EnableButtons(true);
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
