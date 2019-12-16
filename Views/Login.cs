using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Blockchain_wpf_client.Views
{
    public partial class Login : Form
    {
        public HttpClient httpClient;
        public Login()
        {
            InitializeComponent();
            httpClient = new HttpClient();
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }

        public async void loginButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
            string path = "/auth/login";
            var response = await httpClient.PostAsync(Config.basicUrl + path, new StringContent(JsonConvert.SerializeObject(new {Username = "", Password = "" }),Encoding.UTF8, "application/json"));
            var contents = await response.Content.ReadAsStringAsync();

            Console.WriteLine(contents);
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Program.registerForm.Show();
            this.Hide();
        }
    }
}
