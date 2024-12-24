﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Totatprice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
