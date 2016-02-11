using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            Login lgn = new Login();
            if (tB_username.Text == "Klas" && tB_Password.Text == "klas123")
            {
                label_Error.Text = "Banned for life bitch";
            }
            else if (tB_username.Text == "Göran" && tB_Password.Text == "göran123")
            {
                this.Visible = false;
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                label_Error.Text = "Non existing username";
            }

        }
    }
}
