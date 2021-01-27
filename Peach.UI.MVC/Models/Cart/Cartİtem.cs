using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Models.Cart
{
    public class Cartİtem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ClothesArtUrl { get; set; }
        public short Amount { get; set; }
        public decimal SubTotal => Price * Amount;
    }
}
