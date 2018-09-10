using System;
using System.Windows.Forms;
using FEgne6;

namespace HentRestgaeld
{
    public partial class UserControlEgne : UserControl
    {
        public Egne_Utils egne_utils;

        public UserControlEgne(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            egne_utils = new Egne_Utils(miljoe, afsender_partid, jnummer);
            InitializeComponent();
            Dock = DockStyle.Fill;
            comboBox1.DataSource = Enum.GetValues(typeof(FEgne6.Kodeliste4));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            egne_utils.GyldigFraDato = dateTimePicker1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            egne_utils.Institut = (FEgne6.Kodeliste4)comboBox1.SelectedIndex;
        }
    }
}
