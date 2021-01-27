using Peach.Core.DataAccess.EntityFramework;
using Peach.DAL.Abstract;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.DAL.Concrete.Repository
{
    class CategoryRepository : EFRepositoryBase<Category, PeachDbContext>,ICategoryDAL
    {
    }
}
