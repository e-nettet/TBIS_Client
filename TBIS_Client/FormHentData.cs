using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using HentRestgaeld.ServiceReferenceTBIS;

namespace HentRestgaeld
{
    public enum Miljoe { Test, Produktion}

    public partial class FormHentData : Form
    {
        private ValidatePartyResponse validatePartyResponse;
        private DataType dataType;
        private TransactionReponse transactionResponse;
        private RKNet_Utils rknet_utils;
        private string outputpath;
        private string inputpath;
        
        public FormHentData()
        {
            InitializeComponent();
            this.Text = this.ProductName + " (version " + this.ProductVersion + ")";
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            comboBoxDataType.DataSource = Enum.GetValues(typeof(DataType));
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
                        if (!backgroundWorkerValidateParty.IsBusy) { backgroundWorkerValidateParty.RunWorkerAsync(); }
                        break;
                    }
                case 1:
                    {
                        InsertUserControlOnTabPageInput();
                        SetMessage("OK - password udløber om " + validatePartyResponse.passwordExpireDays.ToString() + " dage.");
                        wizardTabcontrol1.SelectedIndex += 1;
                        EnableButtons(true);
                        break;
                    }
                case 2:
                    {
                        if (!backgroundWorkerHentData.IsBusy) { backgroundWorkerHentData.RunWorkerAsync(); };
                        break;
                    }
                default: break;
            }
        }

        private string GetEndpointAddress()
        {
            string s;
            switch (userControlLogon1.Miljoe)
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
            client.ClientCredentials.UserName.UserName = userControlLogon1.PartID;
            client.ClientCredentials.UserName.Password = userControlLogon1.Password;
            return (client);
        }

        private void ButtonTilbage_Click(object sender, EventArgs e)
        {
            wizardTabcontrol1.SelectedIndex -= 1;
            EnableButtons(true);
        }

        private void BackgroundWorkerValidateParty_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerValidateParty.ReportProgress(0, "Validerer partid og password");
            try
            {
                ServiceReferenceTBIS.MainClient client = GetMainClient();
                ValidatePartyResponse validatePartyResponse = client.validateParty(userControlLogon1.PartID, userControlLogon1.Password);
                this.validatePartyResponse = validatePartyResponse;
                // XMLUtils.WriteXML(validatePartyResponse, "validePartyResponse.xml");
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
                    toolStripStatusLabel1.Text = "Password udløber om " + validatePartyResponse.passwordExpireDays.ToString() + " dage.";
                }
            }
            catch (Exception f) { toolStripStatusLabel1.Text = f.Message; }
            finally { EnableButtons(true); }
        }

        private void BackgroundWorkerValidateParty_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();
            
        }

        private void BackgroundWorkerHentData_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerHentData.ReportProgress(0, "Henter data");
            try
            {
                ServiceReferenceTBIS.MainClient client = GetMainClient();
                transactionResponse = 
                    client.doTransaction(
                        userControlLogon1.PartID, 
                        userControlLogon1.Password, 
                        rknet_utils.GetInfoFlowName(),
                        rknet_utils.GetModtagerpart(),
                        rknet_utils.GetQuery())
                    ;
                backgroundWorkerHentData.ReportProgress(0, transactionResponse.backEndStatusText);
            }
            catch (Exception f) { backgroundWorkerHentData.ReportProgress(0, f.Message); }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            inputpath = FileUtils.SaveToTempAndReturnFilepath(rknet_utils.GetQuery());
            linkLabelInput.Links.Clear();
            linkLabelInput.Links.Add(0, linkLabelInput.Text.Length, inputpath);

            outputpath = FileUtils.SaveToTempAndReturnFilepath(transactionResponse.resultString);
            linkLabelOutput.Links.Clear();
            linkLabelOutput.Links.Add(0, linkLabelOutput.Text.Length, outputpath);

            if (!(transactionResponse.backEndStatusCode== 0))
            {
                toolStripStatusLabel1.Text = 
                    transactionResponse.backEndStatusCode.ToString() + " " + transactionResponse.backEndStatusText;
            }
            wizardTabcontrol1.SelectedIndex += 1;
            EnableButtons(true);
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void InsertUserControlOnTabPageInput()
        {
            dataType = (DataType)comboBoxDataType.SelectedIndex;
            tabPageInput.Controls.Clear();

            switch (dataType) 
            {
                case DataType.AllePapirer:
                    tabPageInput.Controls.Add(new UserControlAlle(userControlLogon1.Miljoe, userControlLogon1.PartID, validatePartyResponse.rknetid));
                    rknet_utils = ((UserControlAlle)tabPageInput.Controls[0]).Alle_utils;
                    break;
                case DataType.EgnePapirer: 
                    tabPageInput.Controls.Add(new UserControlEgne(userControlLogon1.Miljoe, userControlLogon1.PartID, validatePartyResponse.rknetid));
                    rknet_utils = ((UserControlEgne)tabPageInput.Controls[0]).egne_utils;
                    break;
                case DataType.Omregningskurstabller:
                    tabPageInput.Controls.Add(new UserControlOmregningstabel(userControlLogon1.Miljoe, userControlLogon1.PartID, validatePartyResponse.rknetid));
                    rknet_utils = ((UserControlOmregningstabel)tabPageInput.Controls[0]).Omregningstabller_Utils;
                    break;
                case DataType.Priser: 
                    tabPageInput.Controls.Add(new UserControlPriser(userControlLogon1.Miljoe, userControlLogon1.PartID, validatePartyResponse.rknetid));
                    rknet_utils = ((UserControlPriser)tabPageInput.Controls[0]).Priser_utils;
                    break;
                case DataType.Restgaeld:
                    tabPageInput.Controls.Add(new UserControlRestgaeld(userControlLogon1.Miljoe, userControlLogon1.PartID, validatePartyResponse.rknetid));
                    rknet_utils = ((UserControlRestgaeld)tabPageInput.Controls[0]).restgaeld_utils;
                    break;
                case DataType.Satser:
                    tabPageInput.Controls.Add(new UserControlSatser(userControlLogon1.Miljoe, userControlLogon1.PartID, validatePartyResponse.rknetid));
                    rknet_utils = ((UserControlSatser)tabPageInput.Controls[0]).Satser_utils;
                    break; 
                default: break;
            }
        }
    }
}
