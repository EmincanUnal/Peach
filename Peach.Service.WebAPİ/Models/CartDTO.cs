using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.Service.WebAPİ.Models
{
    public class CartDTO
    {
        public int ClothingID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ClothesArtUrl { get; set; }
    }
}
