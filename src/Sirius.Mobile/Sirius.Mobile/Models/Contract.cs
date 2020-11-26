using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Mobile.Models
{
    public class Contract
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("terminationCondition")]
        public string TerminationCondition { get; set; }

        [JsonProperty("conclusionCondition")]
        public string ConclusionCondition { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("companyView")]
        public Company CompanyView { get; set; }
    }
}
