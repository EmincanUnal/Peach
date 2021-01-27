using Peach.BLL.Abstract;
using Peach.DAL.Abstract;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peach.BLL.Concrete
{
    class ClothingService : IClothingBLL
    {
        IClothingDAL clothingDAL;
        public ClothingService(IClothingDAL dal)
        {
            clothingDAL = dal;
        }
        void CheckName(Clothing entity)
        {
            if (entity.Name.Length<2)
            {
                throw new Exception("İsim 2 karakterden fazla olmalıdır.");
            }
        }
        void CheckStocks(Clothing entity)
        {
            if (entity.Stock<=0)
            {
                throw new Exception("Stok miktari 0 dan büyük olmalıdır");
            }

        }
        void CheckImage(Clothing entity)
        {
            if (entity.ClothesArtUrl==null)
            {
                throw new Exception("Bir fotograf eklemelisiniz");
            }
        }
        public void Insert(Clothing entity)
        {
            CheckName(entity);
            CheckStocks(entity);
            CheckImage(entity);
            clothingDAL.Add(entity);
        }

        public void Update(Clothing entity)
        {
            CheckName(entity);
            CheckStocks(entity);
            clothingDAL.Update(entity);
        }
        public void Delete(Clothing entity)
        {
            entity.IsActive = false;
            clothingDAL.Update(entity);

        }

        public void DeleteByID(int entityid)
        {
            Clothing clothing = Get(entityid);
            clothing.IsActive = false;
            clothingDAL.Update(clothing);
        }

        public Clothing Get(int entityid)
        {
            return clothingDAL.Get(a =>a.ID==entityid&&a.Continued&&a.IsActive, a =>a.Brand, a =>a.Category);
        }

        public ICollection<Clothing> GetAll()
        {
            return clothingDAL.GetAll(a=>a.IsActive==true);
        }

        public ICollection<Clothing> GetClothing()
        {
            return clothingDAL.GetAll(a=>a.Continued&&a.IsActive,a=>a.Category, a=>a.Brand);
        }

        public ICollection<Clothing> GetClothingByCategoryID(int id)
        {
            return clothingDAL.GetAll(a => a.Continued && a.IsActive&&a.CategoryID==id, a => a.Category, a => a.Brand);
        }
        public Clothing GetCartItem(int entityid)
        {
            return clothingDAL.Get(a => a.ID == entityid && a.Continued && a.IsActive);
        }

        public int CountClothing()
        {
            return clothingDAL.GetAll(a => a.IsActive).Count();
        }
        public ICollection<Clothing> GetActiveClothing()
        {
            return clothingDAL.GetAll(a => a.IsActive, a => a.Category, a => a.Brand);
        }

        public ICollection<Clothing> GetClothingByBrand(int id)
        {
            return clothingDAL.GetAll(a => a.Continued && a.IsActive && a.BrandID == id, a => a.Brand, a => a.Category);
        }
        public ICollection<Clothing> GetByCategory(int id)
        {
            return clothingDAL.GetAll(a => a.Continued && a.IsActive == true && a.CategoryID == id, a => a.Brand, a => a.Category);
        }
       

    }
}
