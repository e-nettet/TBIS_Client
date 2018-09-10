using System;
using System.Windows.Forms;

namespace HentRestgaeld
{
    public partial class UserControlAlle : UserControl
    {
        private Alle_Utils alle_utils;

        public UserControlAlle(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            Alle_utils = new Alle_Utils(miljoe, afsender_partid, jnummer);
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public Alle_Utils Alle_utils { get => alle_utils; set => alle_utils = value; }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Alle_utils.Udtraeksdato = dateTimePicker1.Value;
        }
    }
}
