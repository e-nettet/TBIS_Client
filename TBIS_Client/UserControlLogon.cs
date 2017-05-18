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
    public partial class UserControlLogon : UserControl
    {
        private string partID;
        private string password;
        private Miljoe miljoe;

        public UserControlLogon()
        {
            InitializeComponent();
            comboBoxMiljoe.DataSource = Enum.GetValues(typeof(Miljoe));

        }

        public string Password { get => password; set => password = value; }
        public Miljoe Miljoe { get => miljoe; set => miljoe = value; }
        public string PartID { get => partID; set => partID = value; }

        private void ComboBoxMiljoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Miljoe = (Miljoe)comboBoxMiljoe.SelectedIndex;
        }

        private void TextBoxPartID_TextChanged(object sender, EventArgs e)
        {
            PartID = textBoxPartID.Text;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            Password = textBoxPassword.Text;
        }
    }
}
