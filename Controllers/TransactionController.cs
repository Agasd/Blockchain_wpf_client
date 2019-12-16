using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blockchain_wpf_client.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Blockchain_wpf_client.Controllers
{
    class TransactionController
    {
        /*public static Transaction getListTransaction()
        {
            HttpClient httpClient = new HttpClient();
            HttpContent httpContent = new StringContent("");

            string path = "/transactions";
            string url = Config.basicUrl + path;

            HttpResponseMessage httpResponse = httpClient.PostAsync(new Uri(url), httpContent).Result;
            string responseBody = httpResponse.Content.ReadAsStringAsync().Result;
            Transaction listedTransaction = JsonConvert.DeserializeObject<Transaction>(responseBody);
            Console.WriteLine(responseBody);
            return listedTransaction;
        }*/

        //public void Put (string postUrl, object)
    }
}
