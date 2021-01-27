using Microsoft.AspNetCore.Mvc;
using Peach.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ClothingDetails()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetClothing([FromBody]List<ClothingVM> clothings)
        {
            if (clothings==null)
            {
                ViewBag.Message = "Ürün bulunamadı";
            }
            return PartialView("_SingleClothing", clothings);
        }
        [HttpPost]
        public IActionResult GetCategory([FromBody] List<CategoryVM> categories)
        {
            if (categories == null)
            {
                ViewBag.Message = "Ürün bulunamadı";
            }
            return PartialView("_singleCategory", categories);
        }
        
    }
}
