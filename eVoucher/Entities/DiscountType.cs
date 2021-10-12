using System.Text.Json.Serialization;

namespace eVoucher.Entities
{
    public class DiscountType : Base
    {
        public int id { get; set; }
        public string name { get; set; }        
    }
}