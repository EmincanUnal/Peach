using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Peach.BLL.Abstract;
using Peach.Model.Entites;
using Peach.UI.MVC.Helper;
using Peach.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Controllers
{
    public class AccountController : Controller
    {


        IUserBLL userBLL;
        public AccountController(IUserBLL user)
        {
            userBLL = user;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]//Formda kullanılan verileri saklamak ve guvenliğini sağlamak için kullanıldı
        public IActionResult Register(UserVM uservm)
        {
            try
            {
                User user = new User()
                {
                    ID = uservm.UserID,
                    FirstName = uservm.FirstName,
                    LastName = uservm.LastName,
                    Email = uservm.Email,
                    Password = uservm.Password,
                    Address = uservm.Address,
                    PhoneNumber = uservm.PhoneNumber,
                    BirthDate=uservm.BirthDate
                };
                userBLL.Insert(user);
                bool result = MailHelper.SendActivationCode(user.FirstName, user.Email, user.ActivationCode);
                if (result)
                {
                    ViewBag.Message = $"{user.Email} send a Activation code.Check your mail.";
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ViewBag.Message = $"We cant send a Activation code .Please check your information";
                    return View();
                }
            }
            catch (Exception)
            {

                ViewBag.Message = "Oppps something wrong";
                return View();
            }
            
            
        }
        public IActionResult ActivationUser(Guid id)
        {
            User newUser = userBLL.GetUserByActivationCode(id);
            if (newUser !=null)
            {
                newUser.IsActive = true;
                userBLL.Update(newUser);
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "There is no user for activation";
                return View();
            }
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken] //Formda kullanılan verileri saklamak ve guvenliğini sağlamak için kullanıldı
        public IActionResult Login(LoginVM login)
        {
            User LoginUser=userBLL.GetUserByLoginData(login.Email, login.Password);
            if (LoginUser !=null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,LoginUser.Email),
                    new Claim(ClaimTypes.Role,LoginUser.Role.ToString()),
                    new Claim(ClaimTypes.UserData,LoginUser.ID.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,LoginUser.FirstName)
                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                if (LoginUser.Role==Model.Enums.UserRole.Standart)
                {
                    return RedirectToAction("Index", "Home");

                }
                else if(LoginUser.Role == Model.Enums.UserRole.Admin)
                {
                    return RedirectToAction("Index", "Management", new  {area="Admin"} );
                }
                else
                {
                    return View();
                }
            }
            else
            {
                ViewBag.Message="Please check your information";
            }
            return View();
        }
        public IActionResult LoginName()
        {
            string name = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return PartialView("_loginModel", name);
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
