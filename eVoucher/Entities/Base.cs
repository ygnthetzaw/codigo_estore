using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eVoucher.Entities
{
    public class Base
    {
        public Base()
        {
            CreatedDate = new DateTime(1900, 1, 1);
            UpdatedDate = new DateTime(1900, 1, 1);
        }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}