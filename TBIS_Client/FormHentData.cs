using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using FRestgaeld6;
using HentRestgaeld.ServiceReferenceTBIS;
using FRestgaeld6;

namespace HentRestgaeld
{
    public enum Miljoe { Test, Produktion}
    public enum DataType { Restgaeld, Omregningskurstabller, EgneKurser, AlleKurser, Satser, Priser }

    public partial class FormHentData : Form
    {
        private ValidatePartyResponse validatePartyResponse;

        private DataType dataType;
        private FRestgaeld6.Kodeliste4 realkreditinstitut;
        private TransactionReponse transactionResponse;
        string outputpath;
        string inputpath;

        public Kodeliste4 Realkreditinstitut { get => realkreditinstitut; set => realkreditinstitut = value; }

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
                        SetMessage("OK");
                        switch (dataType)
                        {
                            case DataType.Restgaeld:
                                {
                                    wizardTabcontrol1.SelectedIndex += 1;
                                    break;
                                } 
                            case DataType.Omregningskurstabller:
                                {
                                    wizardTabcontrol1.SelectedIndex += 1;
                                    break;
                                }
                            default:
                                {
                                    SetMessage("Not implemented");
                                    break;
                                }
                        }
                        EnableButtons(true);
                        break;
                    }
                case 2:
                    {
                        GetData();
                        break;
                    }
                default: break;
            }
        }

        private void GetData()
        {
            switch ((DataType)comboBoxDataType.SelectedIndex)
            {
                case DataType.AlleKurser:
                    if (backgroundWorkerAlleKurser.IsBusy) { backgroundWorkerAlleKurser.RunWorkerAsync(); };
                    break;
                case DataType.EgneKurser:
                    if (!backgroundWorkerEgneKurser.IsBusy) { backgroundWorkerEgneKurser.RunWorkerAsync(); };
                    break;
                case DataType.Omregningskurstabller:
                    if (!backgroundWorkerOmregningskurstabeller.IsBusy) { backgroundWorkerOmregningskurstabeller.RunWorkerAsync(); };
                    break;
                case DataType.Priser:
                    if (!backgroundWorkerPriser.IsBusy) { backgroundWorkerPriser.RunWorkerAsync(); };
                    break;
                case DataType.Restgaeld:
                    if (!backgroundWorkerHentRestgaeld.IsBusy) { backgroundWorkerHentRestgaeld.RunWorkerAsync(); };
                    break;
                case DataType.Satser:break;
                default:break;
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
            return (client);
        }

        private ValidatePartyResponse GetValidatePartyResponse()
        {
            ServiceReferenceTBIS.MainClient client = GetMainClient();
            ValidatePartyResponse response = client.validateParty(userControlLogon1.PartID, userControlLogon1.Password);
            return (response);
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

        private void BackgroundWorkerValidateParty_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();
        }

        private void BackgroundWorkerHentRestgaeld_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerHentRestgaeld.ReportProgress(0, "Henter restgæld");
            try
            {
                inputpath = FileUtils.SaveToTempAndReturnFilepath(userControlRestgaeldInput1.GetQuery(userControlLogon1.Miljoe));
                ServiceReferenceTBIS.MainClient client = GetMainClient();
                transactionResponse = 
                    client.doTransaction(userControlLogon1.PartID, userControlLogon1.Password, "F [rkn] Restgaeld 6 XML", 
                    userControlRestgaeldInput1.GetModtagerPart(userControlLogon1.Miljoe), userControlRestgaeldInput1.GetQuery(userControlLogon1.Miljoe));
                backgroundWorkerHentRestgaeld.ReportProgress(0, transactionResponse.backEndStatusText);
            }
            catch (Exception f) { backgroundWorkerHentRestgaeld.ReportProgress(0, f.Message); }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.UserState.ToString();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            linkLabelInput.Links.Clear();
            linkLabelInput.Links.Add(0, linkLabelInput.Text.Length, inputpath);

            outputpath = FileUtils.SaveToTempAndReturnFilepath(transactionResponse.resultString);
            linkLabelOutput.Links.Clear();
            linkLabelOutput.Links.Add(0, linkLabelOutput.Text.Length, outputpath);

            if (!(transactionResponse.backEndStatusCode== 0)){ toolStripStatusLabel1.Text = "Fejl under hent data. Statuskode: " + transactionResponse.backEndStatusCode.ToString(); }
            wizardTabcontrol1.SelectedIndex += 1;
            EnableButtons(true);
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void backgroundWorkerOmregningskurstabeller_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorkerOmregningskurstabeller.ReportProgress(0, "Henter omregningskurstabeller");
            try
            {
                string query = Omregningstabller_Utils.GetQueryString(userControlLogon1.Miljoe, userControlLogon1.PartID, userControlOmregningstabelInput1.GyldigFraDato);
                inputpath = FileUtils.SaveToTempAndReturnFilepath(query);
                ServiceReferenceTBIS.MainClient client = GetMainClient();
                transactionResponse =
                    client.doTransaction(userControlLogon1.PartID, userControlLogon1.Password, "F [rkn] Tabeller 6 XML",
                    Omregningstabller_Utils.GetModtagerPart(userControlLogon1.Miljoe), query);
                backgroundWorkerHentRestgaeld.ReportProgress(0, transactionResponse.backEndStatusText);
            }
            catch (Exception f) { backgroundWorkerHentRestgaeld.ReportProgress(0, f.Message); }


        }

        private void comboBoxDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataType = (DataType)comboBoxDataType.SelectedIndex;
            userControlOmregningstabelInput1.Visible = (dataType == DataType.Omregningskurstabller);
            userControlRestgaeldInput1.Visible = (dataType == DataType.Restgaeld);

        }
    }
}
