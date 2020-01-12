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
        [JsonProperty("public_key")]
        public string publicKey { get; set; }

        [JsonProperty("private_key")]
        public string privateKey { get; set; }

    }
}
