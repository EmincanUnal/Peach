using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peach.BLL.Abstract;
using Peach.Model.Entites;
using Peach.Service.WebAPİ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.Service.WebAPİ.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryBLL categoryBLL;
        public CategoryController(ICategoryBLL bll)
        {
            categoryBLL = bll;
        }
        //Kategorileri dto listesine cevirme methodu
        List<CategoryDTO> categoryDTOList (ICollection<Category> listcategory)
        {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            foreach (Category item in listcategory)
            {
                categories.Add(new CategoryDTO()
                {
                    CategoryID=item.ID,
                    CategoryName=item.CategoryName,
                    Description=item.Description,
                    IsActive=item.IsActive
                });
            }
            return categories;
        }
        //Bütün kategorileri ajax ile basmak için olusturuldu.BLL de olan GetAll methodu kullanıldıgından bll katmanında yeni method oluşturmadım
        public IActionResult GetCategory()
        {
            List<CategoryDTO> categories = categoryDTOList(categoryBLL.GetAll());
            return Ok(categories);
        }
        //Admin home ekranında toplam sayıyı göstermek için oluşturdugum methoddur
        public IActionResult Counter()
        {
            return Ok(categoryBLL.CountCategory());
        }
        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            Category category = categoryBLL.Get(id);
            CategoryDTO categoryDTO = new CategoryDTO()
            {
                CategoryID = category.ID,
                CategoryName = category.CategoryName,
                Description = category.Description,
                IsActive=category.IsActive
            };
            return Ok(categoryDTO);

        }
        //Admin ekranında yapmış oldugum update işlemi için oluşturdugum methoddur
        [HttpPost]
        public IActionResult UpdateCategory([FromBody] CategoryDTO categoryDTO)
        {
            try
            {
                Category category = new Category()
                {
                    ID=categoryDTO.CategoryID,
                    CategoryName = categoryDTO.CategoryName,
                    Description=categoryDTO.Description,
                    IsActive=categoryDTO.IsActive
                };
                categoryBLL.Update(category);
                return Ok(new { message = "Category is updated", check = true });
            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = false});
            }
        }
        //Admin ekranında yapmış oldugum ekleme işlemi için oluşturdugum methoddur
        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryDTO categoryDTO)
        {
            try
            {
                Category category = new Category()
                {
                    CategoryName = categoryDTO.CategoryName,
                    Description = categoryDTO.Description
                };
                categoryBLL.Insert(category);
                return Ok(new { message = "Category is added", check = true });
            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = true });
            }
        }
        //Admin ekranında yapmış oldugum silme işlemi için oluşturdugum methoddur
        [HttpGet("{id}")]
        public IActionResult DeleteCategoryById(int id)
        {
            categoryBLL.DeleteByID(id);
            return Ok(new { message = "Category is delete", check = true });
        }
        //Aktif olan kategorileri listelemek için oluşturdugum methoddur bll katmanınada eklenmiştir
        public IActionResult GetCategoryActive()
        {
            List<CategoryDTO> categories = categoryDTOList(categoryBLL.GetAllActive());
            return Ok(categories);
        }

    }
}
