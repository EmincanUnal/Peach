using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.BLL.Abstract
{
   public interface IClothingBLL : IBaseBLL<Clothing>
    {
        ICollection<Clothing> GetClothing();
        ICollection<Clothing> GetClothingByCategoryID(int id);
        Clothing GetCartItem(int entityid);
        ICollection<Clothing> GetByCategory(int id);
        ICollection<Clothing> GetClothingByBrand(int id);
        ICollection<Clothing> GetActiveClothing();
        int CountClothing();
    }
    
}
