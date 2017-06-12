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
    public partial class UserControlPriser : UserControl
    {
        private Priser_Utils priser_utils;

        public UserControlPriser(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            priser_utils = new Priser_Utils(miljoe, afsender_partid, jnummer);
            InitializeComponent();
            comboBoxForretningsområde.DataSource = Enum.GetValues(typeof(FPriser6.Kodeliste12));
            comboBoxInstitut.DataSource = Enum.GetValues(typeof(FPriser6.Kodeliste4));
        }

        public Priser_Utils Priser_utils { get => priser_utils; set => priser_utils = value; }

        private void comboBoxInstitut_SelectedIndexChanged(object sender, EventArgs e)
        {
            priser_utils.Institut = (FPriser6.Kodeliste4)comboBoxInstitut.SelectedIndex;
        }

        private void comboBoxForretningsområde_SelectedIndexChanged(object sender, EventArgs e)
        {
            priser_utils.Forretningsomraade = (FPriser6.Kodeliste12)comboBoxForretningsområde.SelectedIndex;
        }
    }
}
