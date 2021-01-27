using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.Model.Entites
{
  public  class OrderDetail
    {
        public int OrderID { get; set; }
        public int ClothingID { get; set; }
        public short Quantity { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public Order Order { get; set; }
        public Clothing Clothing { get; set; }
    }
}
