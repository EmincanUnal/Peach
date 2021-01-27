using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.Service.WebAPİ.Models
{
    public class BrandDTO
    {
        public int BrandID { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public bool  IsActive { get; set; }

    }
}
