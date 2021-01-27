using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Models.Cart
{
    public class CartVM
    {
        public int ClothingID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ClothesArtUrl { get; set; }
    }
}
