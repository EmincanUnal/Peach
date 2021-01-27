using Peach.BLL.Abstract;
using Peach.DAL.Abstract;
using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.BLL.Concrete
{
    class OrderService : IOrderBLL
    {
        IOrderDAL orderDAL;
        public OrderService(IOrderDAL dal)
        {
            orderDAL = dal;
        }
        void CheckOrderDate(Order order)
        {
            if (order.OrderDate>DateTime.Now)
            {
                throw new Exception("Şipariş tarihi bugunden sonra olmalıdır");
            }
        }
        public void Insert(Order entity)
        {
            CheckOrderDate(entity);
            orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            CheckOrderDate(entity);
            orderDAL.Update(entity);
        }
        public void Delete(Order entity)
        {
            entity.IsActive = false;
            orderDAL.Update(entity);
        }

        public void DeleteByID(int entityid)
        {
            Order order = Get(entityid);
            order.IsActive = false;
            orderDAL.Update(order);
        }

        public Order Get(int entityid)
        {
            return orderDAL.Get(a => a.ID == entityid);
        }

        public ICollection<Order> GetAll()
        {
            return orderDAL.GetAll();
        }

     
    }
}
