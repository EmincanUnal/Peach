using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Areas.Admin.Models
{
    public class ClothingVM
    {
        public int ClothingID { get; set; }
        public string Name { get; set; }
        public string ClothingArtUrl { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool Continued { get; set; }
        public bool DisCounted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
