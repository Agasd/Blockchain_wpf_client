using Blockchain_wpf_client.Controllers;
using Blockchain_wpf_client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain_wpf_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Wallet generatedWallet = WalletController.generateWallet();
            publicBox.Text = generatedWallet.publicKey;
            privateBox.Text = generatedWallet.privateKey;

        }

        private void checkFunds_Click(object sender, EventArgs e)
        {
            String public_key = fundBox.Text;
            String balance = WalletController.getBalance(public_key);
            fundsLabel.Text = balance;
        }
    }
}
