using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace eVoucher.Entities
{
    public class BuyType : Base
    {
        public int id { get; set; }
        public string typename {get;set;}
    }
}