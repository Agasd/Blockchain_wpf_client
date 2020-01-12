using Blockchain_wpf_client.Models;
using BlockchainOnline.Models;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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

            var json = new JavaScriptSerializer().Serialize(new { username = "admin", password = "pass" });

            HttpClient http = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            string path = "/auth/login";
            string url = Config.basicUrl + path;

            HttpResponseMessage response = http.PostAsync(new Uri(url), content).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;

            TokenDTO token = JsonConvert.DeserializeObject<TokenDTO>(responseBody);

            json = new JavaScriptSerializer().Serialize("");

            http = new HttpClient();
            content = new StringContent(json, Encoding.UTF8, "application/json");

            path = "/Users/";
            url = Config.basicUrl + path;
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.tokenString);

            response = http.GetAsync(new Uri(url)).Result;
            responseBody = response.Content.ReadAsStringAsync().Result;
            DataTable t = new DataTable();

            LinkedList<UserInfo> uinfo = new LinkedList<UserInfo>();
            profileDataGridView.DataSource = uinfo.Append(JsonConvert.DeserializeObject<UserInfo>(responseBody)).ToList();
            profileDataGridView.Refresh();
        }
        private async void WalletButton_ClickAsync(object sender, EventArgs e)
        {

            var json = new JavaScriptSerializer().Serialize(new { username = "admin", password = "pass" });

            HttpClient http = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            string path = "/auth/login";
            string url = Config.basicUrl + path;

            HttpResponseMessage response = http.PostAsync(new Uri(url), content).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;

            TokenDTO token = JsonConvert.DeserializeObject<TokenDTO>(responseBody);

            json = new JavaScriptSerializer().Serialize("");

            http = new HttpClient();
            content = new StringContent(json, Encoding.UTF8, "application/json");

            path = "/Users/";
            url = Config.basicUrl + path;
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.tokenString);

            response = http.GetAsync(new Uri(url)).Result;
            responseBody = response.Content.ReadAsStringAsync().Result;
            DataTable t = new DataTable();

            LinkedList < Wallet> wallets = new LinkedList<Wallet>();
            UserInfo uinfo = JsonConvert.DeserializeObject<UserInfo>(responseBody);
            walletDataGridView.DataSource = uinfo.Wallets.ToList();
            walletDataGridView.Refresh();
        }

        private async void TransactionButton_Click(object sender, EventArgs e)
        {
            var json = new JavaScriptSerializer().Serialize(new {username = "admin", password = "pass"});

            HttpClient http = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            string path = "/auth/login";
            string url = Config.basicUrl + path;

            HttpResponseMessage response = http.PostAsync(new Uri(url), content).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;

           TokenDTO token = JsonConvert.DeserializeObject<TokenDTO>(responseBody);

            json = new JavaScriptSerializer().Serialize("");

            http = new HttpClient();
            content = new StringContent(json, Encoding.UTF8, "application/json");

            path = "/Transactions/getall";
            url = Config.basicUrl + path;
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.tokenString);

            response = http.GetAsync(new Uri(url)).Result;
            responseBody = response.Content.ReadAsStringAsync().Result;
            DataTable t = new DataTable();
            
            transactionsDataGridView.DataSource = new LinkedList<Transaction>(JsonConvert.DeserializeObject<Transaction[]>(responseBody)).ToList();
            transactionsDataGridView.Refresh();
            //tvm.transactions = new LinkedList<Transaction>(JsonConvert.DeserializeObject<Transaction[]>(responseBody));
        }

        private void TransactionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WalletDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
