using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain_wpf_client.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.registerForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }
    }
}
