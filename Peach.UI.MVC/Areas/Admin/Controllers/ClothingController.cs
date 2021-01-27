using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peach.UI.MVC.Areas.Admin.Helpers;
using Peach.UI.MVC.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClothingController : Controller
    {
        [Obsolete]
        IHostingEnvironment _environment;
        [Obsolete]
        public ClothingController(IHostingEnvironment hosting)
        {
            _environment = hosting;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult AddClothing()
        {
            return View();
        }


        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetClothingList([FromBody]List<ClothingVM> clothings)
        {
            if (clothings==null)
            {
                ViewBag.Message = "There is no clothes";
            }
            return PartialView("_singleClothingList", clothings);
        }
        [HttpPost]
        public IActionResult GetBrandFilters([FromBody] List<BrandVM> brands)
        {
            if (brands == null)
            {
                ViewBag.Message = "There is no brand";
            }
            return PartialView("_singleBrandFilters", brands);
        }

        [HttpPost]
        public IActionResult GetCategoryFilters([FromBody] List<CategoryVM> categories)
        {
            if (categories == null)
            {
                ViewBag.Message = "There is no category";
            }
            return PartialView("_singleCategoryFilters", categories);
        }

        [HttpPost]
        [Obsolete]
        public IActionResult AddClothingImg([FromForm] IFormFile file)
        {
            string imgClothingUrl = ImgHelpers.GetImageUrl(file, _environment);

            return Ok(new { imgUrl = imgClothingUrl });
        }

    }
}
