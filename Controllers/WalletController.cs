using Blockchain_wpf_client.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Blockchain_wpf_client.Controllers
{
    public static class WalletController
    {
        public static Wallet generateWallet() {


            HttpClient http = new HttpClient();
            HttpContent content = new StringContent(""); 

            string path = "/wallets";
            string url = Config.basicUrl + path;

            HttpResponseMessage response = http.PostAsync(new Uri(url),content).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;
            Wallet generatedWallet = JsonConvert.DeserializeObject<Wallet>(responseBody);
            return generatedWallet;
        }

        public static String getBalance(String public_key)
        {


            HttpClient http = new HttpClient();

            string path = "/wallets/";
            string url = Config.basicUrl + path + public_key;

            HttpResponseMessage response = http.GetAsync(new Uri(url)).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseBody);
            return responseBody;
        }
    }
}
