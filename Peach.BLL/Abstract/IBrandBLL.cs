using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.BLL.Abstract
{
   public interface IBrandBLL:IBaseBLL<Brand>
    {
        ICollection<Brand> GetAllActive();
        int CountBrand();
    }
}
