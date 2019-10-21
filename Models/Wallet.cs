using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_wpf_client.Models
{
    public class Wallet
    {
        [JsonProperty("publicKey")]
        public string publicKey { get; set; }

        [JsonProperty("privateKey")]
        public string privateKey { get; set; }

    }
}
