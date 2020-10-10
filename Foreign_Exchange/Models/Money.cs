using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Foreign_Exchange.Models
{
    public class Money
    {
        [Required]
        [RegularExpression(@"\d", ErrorMessage = "Only Numbers")]
        public decimal Euro { get; set; }
        public decimal CAD { get; set; }
        public decimal CNY { get; set; }
        public decimal USD { get; set; }
        public decimal GBP { get; set; }
    }
}