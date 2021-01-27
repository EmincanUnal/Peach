using Peach.BLL.Abstract;
using Peach.DAL.Abstract;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peach.BLL.Concrete
{
    class BrandService : IBrandBLL
    {
        IBrandDAL brandDAL;
        public BrandService(IBrandDAL dal)
        {
            brandDAL = dal; 
        }
        void CheckCompanyName(Brand entity)
        {
            if (string.IsNullOrEmpty(entity.CompanyName))
            {
                throw new Exception("Marka adı boş geçilemez");
            }
        }
        void CheckDescription(Brand entity)
        {
            if (string.IsNullOrEmpty(entity.Description))
            {
                throw new Exception("Açıklaması boş geçilemez");
            }
        }
        public void Delete(Brand entity)
        {
            entity.IsActive = false;
            brandDAL.Update(entity);
        }
        public void Insert(Brand entity)
        {
            CheckCompanyName(entity);
            CheckDescription(entity);
            brandDAL.Add(entity);
        }

        public void Update(Brand entity)
        {
            CheckCompanyName(entity);
            CheckDescription(entity);
            brandDAL.Update(entity);
        }

        public void DeleteByID(int entityid)
        {
            Brand brand = Get(entityid);
            brand.IsActive = false;
            brandDAL.Update(brand);
        }

        public Brand Get(int entityid)
        {
            return brandDAL.Get(a => a.ID == entityid);
        }

        public ICollection<Brand> GetAll()
        {
            return brandDAL.GetAll();
        }

        public int CountBrand()
        {
            return brandDAL.GetAll(a => a.IsActive).Count();
        }

        public ICollection<Brand> GetAllActive()
        {
            return brandDAL.GetAll(a => a.IsActive);
        }
    }
}
