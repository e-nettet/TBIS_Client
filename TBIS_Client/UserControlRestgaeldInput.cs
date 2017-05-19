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
    public partial class UserControlRestgaeldInput : UserControl
    {
        private Kodeliste4 realkreditinstitut;
        private string pantnummer;
        private string laanenummer;
        private string kontrolkode;

        public UserControlRestgaeldInput()
        {
            InitializeComponent();
            comboBoxRealkreditinstitut.DataSource = Enum.GetValues(typeof(Kodeliste4));
        }

        public Kodeliste4 Realkreditinstitut { get => realkreditinstitut; set => realkreditinstitut = value; }
        public string Pantnummer { get => pantnummer; set => pantnummer = value; }
        public string Kontrolkode { get => kontrolkode; set => kontrolkode = value; }
        public string Laanenummer { get => laanenummer; set => laanenummer = value; }

        public string GetModtagerPart(Miljoe miljoe)
        {
            string s = RESTGAELD_Utils.GetPart(realkreditinstitut, miljoe);
            return (s);
        }

        public string GetQuery(Miljoe miljoe)
        {
            FRestgaeld6.FRestgaeld6_Type f = RESTGAELD_Utils.GetFRestgaeld6_Type(
                RESTGAELD_Utils.GetPart(realkreditinstitut, miljoe), 
                pantnummer, 
                kontrolkode, 
                realkreditinstitut, 
                laanenummer);
            string query = RKNetUtils.GetClassAsXMLString(f);
            return (query);
        }

        private void ComboBoxRealkreditinstitut_SelectedIndexChanged(object sender, EventArgs e)
        {
            Realkreditinstitut = (Kodeliste4)comboBoxRealkreditinstitut.SelectedIndex;
        }

        private void TextBoxPantnummer_TextChanged(object sender, EventArgs e)
        {
            Pantnummer = textBoxPantnummer.Text;
        }

        private void TextBoxLaanenummer_TextChanged(object sender, EventArgs e)
        {
            Laanenummer = textBoxLaanenummer.Text;
        }

        private void TextBoxKontrolkode_TextChanged(object sender, EventArgs e)
        {
            Kontrolkode = textBoxKontrolkode.Text;
        }
    }
}
