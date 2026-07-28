using System;
using System.Collections.Generic;

namespace ECommerceApp
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public User? User { get; set; }

        public List<OrderProduct> OrderProducts { get; set; } = new();

        public Review? Review { get; set; }
    }