using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.Service.WebAPİ.Models
{
    public class ClothingDTO
    {
        public int ClothingID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ClothingArtUrl { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public short Stock { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public bool IsActive { get; set; }

    }
}
