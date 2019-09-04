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
    public partial class UserControlDokumentAktuelHent : UserControl
    {

        private TBGW_Utils tbgw_utils;
        public TBGW_Utils TBGW_utils { get => tbgw_utils; set => tbgw_utils = value; }


        public UserControlDokumentAktuelHent(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            tbgw_utils = new TBGW_Utils(miljoe, afsender_partid, jnummer, DataType.DokumentAktuel);
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public string GetBody()
        {
            string s =  tbgw_utils.GetQuery();
            return s;
        }

        public string GetFilename()
        {
            string s = DataType.DokumentAktuel.ToString();
            s += textBoxDokumentIdentifikator.Text;
            return s;
        }

        private void textBoxDokumentIdentifikator_TextChanged(object sender, EventArgs e)
        {
            tbgw_utils.DokumentIdentifikator = textBoxDokumentIdentifikator.Text;
        }
    }
}
