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
    public partial class UserControlOmregningstabelInput : UserControl
    {
        public UserControlOmregningstabelInput()
        {
            InitializeComponent();
        }

        private DateTime gyldigFraDato;

        public DateTime GyldigFraDato { get => gyldigFraDato; set => gyldigFraDato = value; }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            gyldigFraDato = dateTimePicker1.Value;
        }
    }
}
