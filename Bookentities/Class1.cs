using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace Bookentities
{
    public class Bookscl
    {
        
        [JsonPropertyName("id")]
        public string id { set; get; }
        [JsonPropertyName("name")]
        public string name { set; get; }
        [JsonPropertyName("authorName")]
        public string authorName { set; get; }
    }
}
