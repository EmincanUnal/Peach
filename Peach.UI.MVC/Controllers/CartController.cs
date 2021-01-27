using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peach.BLL.Abstract;
using Peach.Model.Entites;
using Peach.UI.MVC.Helper;
using Peach.UI.MVC.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Controllers
{
    
    public class CartController : Controller
    {
        IUserBLL userBLL;
        IOrderBLL orderBLL;

        public CartController(IUserBLL bLL, IOrderBLL orderbll)
        {
            userBLL = bLL;
            orderBLL = orderbll;

        }
        public IActionResult Index()
        {

            return View(HttpContext.Session.Get<MyCart>("cart"));
        }
        [HttpPost]
        public IActionResult AddToCart([FromBody]CartVM cart,short amount)
        {

            MyCart sepet = HttpContext.Session.Get<MyCart>("cart");
            Cartİtem cartİtem = new Cartİtem()
            {
                ID = cart.ClothingID,
                Price = cart.Price,
                Name = cart.Name,
                Amount = amount,
                ClothesArtUrl=cart.ClothesArtUrl

            };
            sepet.AddCart(cartİtem);
            HttpContext.Session.Set<MyCart>("cart", sepet);
            return Ok();
        }
        public  IActionResult GetCartButton()
        {
            MyCart sepet = HttpContext.Session.Get<MyCart>("cart");
            return PartialView("CartButton", sepet);
        }
        public  IActionResult UpdateToCart(short amount,int id)
        {
            MyCart guncelleneceksepet = HttpContext.Session.Get<MyCart>("cart");
            guncelleneceksepet.Update(id, amount);
            HttpContext.Session.Set<MyCart>("cart", guncelleneceksepet);
            return PartialView("_tableList", guncelleneceksepet);
        }
        public IActionResult DeleteToCart(int id)
        {
            MyCart silineceksepet = HttpContext.Session.Get<MyCart>("cart");
            silineceksepet.Delete(id);
            HttpContext.Session.Set<MyCart>("cart", silineceksepet);
            return PartialView("_tableList", silineceksepet);
        }
      [HttpGet]
      public IActionResult GetOrders()
        {
            MyCart sepet = HttpContext.Session.Get<MyCart>("cart");
            if (string.IsNullOrEmpty(User.FindFirstValue(ClaimTypes.UserData)))
            {
                return RedirectToAction("Login", "Account");
            }
            int userID = int.Parse(User.FindFirstValue(ClaimTypes.UserData));
            Order order = new Order();
            order.OrderDetails = new List<OrderDetail>();
            order.UserID = userID;
            order.ShipAddress =userBLL.GetAddres(userID);
            foreach (Cartİtem item in sepet.GetAllCartItem)
            {
                order.OrderDetails.Add(new OrderDetail() { ClothingID = item.ID, Price = item.Price, Quantity = item.Amount });
            }
            orderBLL.Insert(order);
            return RedirectToAction("Index", "Home");

        }
    }
}
