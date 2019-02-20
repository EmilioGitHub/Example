using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleApp.Models
{
    //класс Заказ
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public Item SelectedItem { get; set; }
        public Person Customer { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Opened;
        public double TotalCost { get; set; }
    }

    public enum OrderStatus
    {
        Opened,
        Closed
    }
}