using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.BLL.Abstract
{
   public interface ICategoryBLL:IBaseBLL<Category>
    {
        ICollection<Category> GetAllActive();
        int CountCategory();
    }
}
