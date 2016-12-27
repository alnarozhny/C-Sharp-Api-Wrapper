﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightLocal
{
    public class BrightLocalClient
    {
        [JsonProperty("client-id")]
        public int clientId { get; set; }
        [JsonProperty("succecss")]
        public bool success { get; set; }
        [JsonProperty("company-name")]
        public string companyName { get; set; }
        [JsonProperty("company-url")]
        public string companyUrl { get; set; }
        [JsonProperty("business-category-id")]
        public int businessCategoryId { get; set; }
    }
}