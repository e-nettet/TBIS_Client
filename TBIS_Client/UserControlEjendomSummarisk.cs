using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HentRestgaeld
{
    public partial class UserControlEjendomSummarisk : UserControl
    {
        public TBGW_Utils TBGW_Utils;

        public UserControlEjendomSummarisk(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            TBGW_Utils = new TBGW_Utils(miljoe, afsender_partid, jnummer, DataType.EjendomSummarisk);
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public string GetBody()
        {
            string s = TBGW_Utils.GetQuery();
            return s;
        }

        public string GetFilename()
        {
            string s = DataType.EjendomSummarisk.ToString();
            s += textBoxCadastralDistrictIdentifier.Text + " " + textBoxMatrikelnummer.Text;
            return s;
        }

        private void textBoxCadastralDistrictIdentifier_TextChanged(object sender, EventArgs e)
        {
            TBGW_Utils.CadastralDistrictIdentifier = textBoxCadastralDistrictIdentifier.Text;

        }

        private void textBoxMatrikelnummer_TextChanged(object sender, EventArgs e)
        {
            TBGW_Utils.Matrikelnummer = textBoxMatrikelnummer.Text;
        }
    }
}
