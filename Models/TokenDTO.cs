using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_wpf_client.Models
{
    public class TokenDTO
    {
        [JsonProperty("tokenString")]
        public string tokenString { get; set; }
    }
}
