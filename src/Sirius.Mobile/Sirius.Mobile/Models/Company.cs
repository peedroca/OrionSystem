using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Mobile.Models
{
    public class Company
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
