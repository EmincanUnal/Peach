using Peach.BLL.Abstract;
using Peach.DAL.Abstract;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peach.BLL.Concrete
{
    class CategoryService : ICategoryBLL

    {
        ICategoryDAL categoryDAL;
        public CategoryService(ICategoryDAL dal)
        {
            categoryDAL = dal;
        }
        void checkCategoryName(Category category)
        {
            if (string.IsNullOrEmpty(category.CategoryName))
            {
                throw new Exception("Kategori adı boş bırakılamaz");
            }
        }
        void checkDescription(Category category)
        {
            if (string.IsNullOrEmpty(category.Description))
            {
                throw new Exception("Açıklama alanı boş bırakılamaz");
            }
        }
        public void Insert(Category entity)
        {
            checkCategoryName(entity);
            checkDescription(entity);
            categoryDAL.Add(entity);
        }

        public void Update(Category entity)
        {
            checkCategoryName(entity);
            checkDescription(entity);
            categoryDAL.Update(entity);
        }
        public void Delete(Category entity)
        {
            entity.IsActive = false;
            categoryDAL.Update(entity);
        }

        public void DeleteByID(int entityid)
        {
            Category category = Get(entityid);
            category.IsActive = false;
            categoryDAL.Update(category);
        }

        public Category Get(int entityid)
        {
            return categoryDAL.Get(a => a.ID == entityid);
        }

        public ICollection<Category> GetAll()
        {
            return categoryDAL.GetAll();
        }

        public int CountCategory()
        {
            return categoryDAL.GetAll(a => a.IsActive).Count();
        }
        public ICollection<Category> GetAllActive()
        {
            return categoryDAL.GetAll(a => a.IsActive);
        }
    }
}
