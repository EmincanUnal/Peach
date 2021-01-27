using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Peach.BLL.Abstract;
using Peach.UI.MVC.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BrandController : Controller
    {
        IBrandBLL brandBLL;
        public BrandController(IBrandBLL brand)
        {
            brandBLL = brand;
        }
        [HttpPost]
        public IActionResult GetBrandList([FromBody] List<BrandVM> brands)
        {
            if (brands == null)
            {
                ViewBag.Message = "We cant list Brand";

            }
            return PartialView("_brandList", brands);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddBrand()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
    }
}
