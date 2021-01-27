using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Areas.Admin.Models
{
    public class BrandVM
    {
        public int BrandId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
