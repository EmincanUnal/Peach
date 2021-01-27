using Peach.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.Model.Entites
{
   public class Brand:BaseEntity
    {
        public Brand()
        {
            IsActive = true;
        }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public ICollection<Clothing> Clothes { get; set; }
       

    }
}
