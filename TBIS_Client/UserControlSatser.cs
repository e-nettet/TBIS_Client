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
    public partial class UserControlSatser : UserControl
    {
        private Satser_Utils satser_utils;

        public UserControlSatser(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            satser_utils = new Satser_Utils(miljoe, afsender_partid, jnummer);
            InitializeComponent();
            comboBoxForretningsomraade.DataSource = Enum.GetValues(typeof(FSatser6.Kodeliste12));
            comboBoxInstitut.DataSource = Enum.GetValues(typeof(FSatser6.Kodeliste4));

        }

        public Satser_Utils Satser_utils { get => satser_utils; set => satser_utils = value; }

        private void comboBoxInstitut_SelectedIndexChanged(object sender, EventArgs e)
        {
            satser_utils.Institut = (FSatser6.Kodeliste4)comboBoxInstitut.SelectedIndex;
        }

        private void comboBoxForretningsomraade_SelectedIndexChanged(object sender, EventArgs e)
        {
            satser_utils.Forretningsomraade = (FSatser6.Kodeliste12)comboBoxForretningsomraade.SelectedIndex;
        }
    }
}
