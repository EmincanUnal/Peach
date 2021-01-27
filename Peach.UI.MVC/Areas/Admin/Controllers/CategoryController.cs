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
    public class CategoryController : Controller
    {
        ICategoryBLL categoryBLL;

        public CategoryController(ICategoryBLL catBLL)
        {
            categoryBLL = catBLL;
        }

        [HttpPost]
        public IActionResult GetCategoryList([FromBody] List<CategoryVM> categories)
        {
            if (categories == null)
            {
                ViewBag.Message = "We cant list Categories";
            }


            return PartialView("_categoryList", categories);

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }


        public IActionResult AddCategory()
        {
            return View();
        }
    }
}
