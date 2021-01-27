using Peach.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.Model.Entites
{
   public class Category:BaseEntity
    {
        public Category()
        {
            IsActive = true;
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Clothing> Clothings { get; set; }

    }
}
