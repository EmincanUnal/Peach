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
    public class BrandController : ControllerBase
    {
        IBrandBLL brandBLL;
        public BrandController(IBrandBLL bll)
        {
            brandBLL = bll;
        }
        //Brandleri dto listesine cevirme methodu
        List<BrandDTO> brandDTOList(ICollection<Brand> ListBrand)
        {
            List<BrandDTO> brands = new List<BrandDTO>();
            foreach (Brand item in ListBrand)
            {
                brands.Add(new BrandDTO()
                {
                    BrandID = item.ID,
                    CompanyName = item.CompanyName,
                    Description = item.Description,
                    IsActive=item.IsActive
                });

            }
            return brands;
        }
        [HttpGet("{id}")]
        public IActionResult GetBrandByID(int id)
        {
            Brand brand = brandBLL.Get(id);
            BrandDTO brandDTO = new BrandDTO()
            {
                BrandID = brand.ID,
                CompanyName = brand.CompanyName,
                Description = brand.Description,
                IsActive=brand.IsActive
            };
            return Ok(brandDTO);

        }
        //Bütün markaları ajax ile basmak çin olusturuldu.BLL de olan GetAll methodu kullanıldıgından bll katmanında yeni method oluşturmadım
        public IActionResult GetBrand()
        {
            List<BrandDTO> brands = brandDTOList(brandBLL.GetAll());
            return Ok(brands);
        }
        //Admin home ekranında toplam sayıyı göstermek için oluşturdugum methoddur
        public IActionResult Counter()
        {
            return Ok(brandBLL.CountBrand());
        }
        //Admin ekranında yapmış oldugum update işlemi için oluşturdugum methoddur
        [HttpPost]
        public IActionResult UpdateBrand([FromBody]BrandDTO brandDTO)
        {
            try
            {
                Brand brand = new Brand()
                {
                    ID = brandDTO.BrandID,
                    CompanyName = brandDTO.CompanyName,
                    Description = brandDTO.Description,
                    IsActive = brandDTO.IsActive
                };
                brandBLL.Update(brand);
                return Ok(new { message = "Brand is updated", check = true });
            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = false });
            }
        }
        //Admin ekranında yapmış oldugum ekleme işlemi için oluşturdugum methoddur
        [HttpPost]
        public IActionResult AddBrand([FromBody] BrandDTO brandDTO)
        {
            try
            {
                Brand brand = new Brand()
                {
                    CompanyName = brandDTO.CompanyName,
                    Description = brandDTO.Description
                };
                brandBLL.Insert(brand);
                return Ok(new { message = "Brand is added", check = true });
            }
            catch (Exception ex)
            {

                return Ok(new { message =ex.Message, check = false });
            }
        }
        //Admin ekranında yapmış oldugum Delete işlemi için oluşturdugum methoddur
        [HttpGet("{id}")]
        public IActionResult DeleteBrandById(int id)
        {
            brandBLL.DeleteByID(id);
            return Ok(new { message = "Brand is delete", check = true });
        }
        //BLL DEKİ getall Meyhodu kullanıldıgı için tekrardan bll e yeni method oluşturulmadı
        public IActionResult GetBrandActive()
        {
            List<BrandDTO> brands = brandDTOList(brandBLL.GetAllActive());
            return Ok(brands);
        }
    }
}
