using Blockchain_wpf_client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain_wpf_client.Views
{
    public partial class main : Form
    {
        public main()
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

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilePanel.BringToFront();

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void populateButton_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            HttpContent httpContent = new StringContent("");

            string path = "/Users";

            var response = await httpClient.PostAsync(Config.basicUrl + path, new StringContent(JsonConvert.SerializeObject(new { Username = "", Password = "" }), Encoding.UTF8, "application/json"));
            var contents = await response.Content.ReadAsStringAsync();
        }

        /*public static IEnumerable<User> GetResponse()
        {
            IEnumerable<User> users = new List<User>();
            using (StreamReader r = new StreamReader("Data.json"));
        }*/

        private async void WalletButton_ClickAsync(object sender, EventArgs e)
        {

            HttpClient httpClient = new HttpClient();
            HttpContent httpContent = new StringContent("");

            string path = "/Wallets";

            /*HttpResponseMessage httpResponse = httpClient.PostAsync(new Uri(url), httpContent).Result;
            string responseBody = httpResponse.Content.ReadAsStringAsync().Result;
            Wallet listedWallet = JsonConvert.DeserializeObject<Wallet>(responseBody);
            Console.WriteLine(responseBody);*/
            var response = await httpClient.PostAsync(Config.basicUrl + path, new StringContent(JsonConvert.SerializeObject(new { Username = "", Password = "" }), Encoding.UTF8, "application/json"));
            var contents = await response.Content.ReadAsStringAsync();
            //walletDataGridView.DataSource = 

        }

        private async void TransactionButton_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            HttpContent httpContent = new StringContent("");

            string path = "/Transactions";

            var response = await httpClient.PostAsync(Config.basicUrl + path, new StringContent(JsonConvert.SerializeObject(new { Username = "", Password = "" }), Encoding.UTF8, "application/json"));
            var contents = await response.Content.ReadAsStringAsync();
        }

        private void TransactionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WalletDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
