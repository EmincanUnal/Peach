using Peach.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.Model.Entites
{
   public class Clothing:BaseEntity
    {
        public Clothing()
        {
            IsActive = true;
            Continued = true;
            Discounted = false;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public string ClothesArtUrl { get; set; }
        public bool Continued { get; set; }
        public bool Discounted { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
