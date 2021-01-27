using Peach.Model.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.BLL.Abstract
{
   public interface IUserBLL : IBaseBLL<User>
    {
        User GetUserByActivationCode(Guid guid);
        User GetUserByLoginData(string mail, string password);
        int CounterUser();
        string GetAddres(int id);
    }
}
