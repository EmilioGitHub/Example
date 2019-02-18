using System;

namespace ExampleApp.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Customer{ get; set; }
        public string Address { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
    }
}