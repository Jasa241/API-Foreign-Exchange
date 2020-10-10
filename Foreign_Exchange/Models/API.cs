using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Foreign_Exchange.Models
{
    public class API
    {
        //{"rates":{"USD":1.173},"base":"EUR","date":"2020-10-02"}

        public object Rates { get; set; }
        [JsonProperty("rates")]
        public Money money { get; set; }
        public string Base { get; set; }
        public DateTime Date { get; set; }
    }
}