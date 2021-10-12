using System.Text.Json.Serialization;

namespace eVoucher.Entities
{
    public class PaymentMethod : Base
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}