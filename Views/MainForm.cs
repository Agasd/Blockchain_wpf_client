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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionPanel.BringToFront();

        }

        private void walletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            walletPanel.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TransactionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Show();
        }

        private void currentEmailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
