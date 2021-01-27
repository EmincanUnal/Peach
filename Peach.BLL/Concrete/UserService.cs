using Peach.BLL.Abstract;
using Peach.DAL.Abstract;
using Peach.Model.Entites;
using Peach.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peach.BLL.Concrete
{
    class UserService : IUserBLL
    {
        IUserDAL userDAL;
        public UserService(IUserDAL dal)
        {
            userDAL = dal;
        }
        void CheckAdres(User user)
        {

            if ( string.IsNullOrEmpty(user.Address) )
            {
                throw new Exception("Degerler boş geçilemez");
            }

        }
        void checkEmail(User user)
        {
            if (!user.Email.Contains("@")|| string.IsNullOrEmpty(user.Email))
            {
                throw new Exception("Email boş geçilemez ve @ içermelidir");
            }
        }
        void checkFullName(User user)
        {
            if (user.FirstName.Length<2||user.LastName.Length<2||string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
            {
                throw new Exception("Ad ve soyad 2 karakterden büyük olmalıdır");
            }
        }
        
        void CheckPassword(User user)
        {
            if (user.Password.Length < 8 ||string.IsNullOrEmpty(user.Password))
            {
                throw new Exception("Şifreniz 8 karakterden büyük olmalı ve özel karakter içermelidir");
            }
            string symbol = "!'^+%&/()=?_,.";
            bool check = false;
            foreach (char item in symbol)
            {
                if (user.Password.Contains(item))
                {
                    check = true;
                }

            }
            if (!check)
            {
                throw new Exception("Şifre özel karakter içermelidir");
            }
        }
        void checkPhone(User user)
        {
            if ( user.PhoneNumber.Length!=11||string.IsNullOrEmpty(user.PhoneNumber))
            {
                throw new Exception("Telefon numarası 11 haneli olmalıdır");
            }
        }
        void checkBirtDate(User user)
        {
            if (user.BirthDate.AddYears(18)>DateTime.Now)
            {
                throw new Exception("18 yasından büyük olmalısınız");
            }

        }
        public void Insert(User entity)
        {
            CheckAdres(entity);
            checkEmail(entity);
            checkFullName(entity);
            CheckPassword(entity);
            checkPhone(entity);
            checkBirtDate(entity);
            entity.Role = UserRole.Standart;
            entity.ActivationCode = Guid.NewGuid();
            userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            CheckAdres(entity);
            checkEmail(entity);
            checkFullName(entity);
            CheckPassword(entity);
            checkPhone(entity);
            checkBirtDate(entity);
            userDAL.Update(entity);
        }
        public void Delete(User entity)
        {
            entity.IsActive = false;
            userDAL.Update(entity);
        }

        public void DeleteByID(int entityid)
        {
            User user = Get(entityid);
            user.IsActive = false;
            userDAL.Update(user);
        }

        public User Get(int entityid)
        {
            return userDAL.Get(a => a.ID == entityid);
        }

        public ICollection<User> GetAll()
        {
            return userDAL.GetAll();
        }

        public User GetUserByActivationCode(Guid guid)
        {
            User Newuser=userDAL.Get(a => a.ActivationCode == guid);
            return Newuser;
        }
        public User GetUserByLoginData(string mail,string password)
        {
            User LoginUser = userDAL.Get(a => a.IsActive&& a.Email==mail&&a.Password==password);
            return LoginUser;
        }

        public int CounterUser()
        {
            return userDAL.GetAll(a => a.IsActive).Count();
        }
        public string GetAddres(int id)
        {
            User user = userDAL.Get(a => a.ID == id);
            return user.Address;
        }

    }
}
