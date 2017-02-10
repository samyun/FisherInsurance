using System;

namespace FisherInsurance.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Price { get; set; }
    }
}