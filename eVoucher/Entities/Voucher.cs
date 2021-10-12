using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace eVoucher.Entities
{
    public class Voucher : Base
    {
        public int id { get; set; }
        public string title { get; set; }        
        public string description { get; set; }
        public DateTime expirydate { get; set; }
        public string imageurl {get; set; }
        public int amount {get; set; }
        public int PaymentMethodId {get; set; }
        public virtual PaymentMethod PaymentMethod {get; set; }
        public int paymentmethoddiscount {get;set;}
        public int DiscountTypeId {get;set;}
        public virtual DiscountType DiscountType {get;set;}
        public int quantity {get;set;}
        public int active {get;set;}

    }
}