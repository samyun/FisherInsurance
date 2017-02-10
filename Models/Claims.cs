using System;

namespace FisherInsurance.Models

{
    public class Claims
    {
        public int ID { get; set; }
        public string PolicyType { get; set; }
        public DateTime LossDate { get; set; }
        public decimal LossAmount { get; set; }
    }

}