using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FRestgaeld6;


namespace HentRestgaeld
{
    public partial class UserControlRestgaeld : UserControl
    {
        public Restgaeld_Utils restgaeld_utils;

        public UserControlRestgaeld(Miljoe miljoe, string afsender_partid, string jnummer)
        {
            restgaeld_utils = new Restgaeld_Utils(miljoe, afsender_partid, jnummer);
            InitializeComponent();
            comboBoxRealkreditinstitut.DataSource = Enum.GetValues(typeof(Kodeliste4));
        }

        private void ComboBoxRealkreditinstitut_SelectedIndexChanged(object sender, EventArgs e)
        {
            restgaeld_utils.Institut = (Kodeliste4)comboBoxRealkreditinstitut.SelectedIndex;
        }

        private void TextBoxPantnummer_TextChanged(object sender, EventArgs e)
        {
            restgaeld_utils.Ejendomsident = textBoxPantnummer.Text;
        }

        private void TextBoxLaanenummer_TextChanged(object sender, EventArgs e)
        {
            restgaeld_utils.Laaneidentifikation = textBoxLaanenummer.Text;
        }

        private void TextBoxKontrolkode_TextChanged(object sender, EventArgs e)
        {
            restgaeld_utils.Kontrolkode = textBoxKontrolkode.Text;
        }
    }
}
