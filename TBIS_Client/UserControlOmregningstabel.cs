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
    public partial class UserControlOmregningstabel : UserControl
    {
        private Omregningstabller_Utils omregningstabller_Utils;

        public UserControlOmregningstabel(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            InitializeComponent();
            omregningstabller_Utils = new Omregningstabller_Utils(miljoe, afsender_partid, jnummer);
        }

        public Omregningstabller_Utils Omregningstabller_Utils { get => omregningstabller_Utils; set => omregningstabller_Utils = value; }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            omregningstabller_Utils.GyldigFraDato = dateTimePicker1.Value;
        }

    }
}
