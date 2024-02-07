using EcommerceGroseryApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGroseryApp.Models
{
    public class Order
    {
        public long Id { get; set; }
        public IEnumerable<CurtItem> Items { get; set; } = Enumerable.Empty<CurtItem>();
        public DateTime Date { get; set; }= DateTime.Now;
        public decimal TotalAmount => Items.Sum(i => i.Amount);
        public OrderStatus Status { get; set; }
        private static IReadOnlyDictionary<OrderStatus, Color> _ordersStatusColors = new Dictionary<OrderStatus, Color>
        {
            [OrderStatus.Placed] = Colors.Yellow,
            [OrderStatus.Cancelled] = Colors.Red,
            [OrderStatus.Confirmed] = Colors.Blue,
            [OrderStatus.Delivered]=Colors.Green

        };
    }
}
