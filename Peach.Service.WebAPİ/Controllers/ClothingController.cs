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
    public class ClothingController : ControllerBase
    {
        IClothingBLL clothingBLL;
        public ClothingController(IClothingBLL  bll)
        {
            clothingBLL = bll;
        }

        //Kıyafetleri dto listesine cevirme methodu
        List<ClothingDTO> clothingDTOList(ICollection<Clothing> ListClothing)
        {
            List<ClothingDTO> clothings = new List<ClothingDTO>();
            foreach (Clothing item in ListClothing)
            {
                clothings.Add(new ClothingDTO()
                {
                    ClothingID=item.ID,
                    Name=item.Name,
                    Price=item.Price,
                    CategoryName=item.Category.CategoryName,
                    ClothingArtUrl=item.ClothesArtUrl,
                    CompanyName=item.Brand.CompanyName,
                    IsActive=item.IsActive
                    
                });
            }
                return clothings;
        }
        //Bütün Kıyafetleri ajax ile basmak için olusturuldu.BLL de olan GetAll methodu kullanıldıgından bll katmanında yeni method oluşturmadım
        public IActionResult GetClothing()
        {
            List<ClothingDTO> clothings = clothingDTOList(clothingBLL.GetClothing());
            return Ok(clothings);
        }
        [HttpGet("{id}")]
        public IActionResult GetClothingByCategory(int id)
        {
            List<ClothingDTO> clothings = clothingDTOList(clothingBLL.GetClothingByCategoryID(id));
            return Ok(clothings);

        }
        [HttpGet("{id}")]
        public IActionResult GetClothingByID(int id)
        {
            Clothing clothings = clothingBLL.Get(id);
            ClothingDTO clothingDTO = new ClothingDTO()
            {
                ClothingID = clothings.ID,
                Name = clothings.Name,
                Price = clothings.Price,
                CategoryID = clothings.CategoryID,
                ClothingArtUrl = clothings.ClothesArtUrl,
                BrandID = clothings.BrandID,
                Stock = clothings.Stock
            };
            return Ok(clothingDTO);

        }

        //Id numarasına göre yakalayıp ürünün tüm bilgilerini aldım ve Homedaki ClothingDetails sayfasında ajax ile bastım.Get methodunu kullandıgım için bll katmanına yeni bir method tanımlamadım
        [HttpGet("{id}")]
        public IActionResult GetCartItemByID(int id)
        {
            Clothing clothings = clothingBLL.GetCartItem(id);
            CartDTO cartDTO = new CartDTO()
            {
                ClothingID = clothings.ID,
                Name = clothings.Name,
                Price = clothings.Price,
                ClothesArtUrl=clothings.ClothesArtUrl
                
            };
            return Ok(cartDTO);

        }
        //Admin home ekranında toplam sayıyı göstermek için oluşturdugum methoddur
        public IActionResult Counter()
        {
            return Ok(clothingBLL.CountClothing());
        }
        //Aktif olan kıyafetleri listelemek için oluşturdugum methoddur bll katmanınada eklenmiştir
        public IActionResult GetClothingActive()
        {
            List<ClothingDTO> clothings = clothingDTOList(clothingBLL.GetActiveClothing());
            return Ok(clothings);
        }
        //Admin ekranındaki filtreleme için yazdıgım methoddur
        [HttpGet("{id}")]
        public IActionResult GetClothingListBrand(int id)
        {
            List<Clothing> clothing = clothingBLL.GetClothingByBrand(id).ToList();

            return Ok(clothingDTOList(clothing));
        }
        //Admin ekranındaki filtreleme için yazdıgım methoddur
        [HttpGet("{id}")]
        public IActionResult GetByCategory(int id)
        {
            List<Clothing> clothings = clothingBLL.GetByCategory(id).ToList();
            return Ok(clothingDTOList(clothings));
        }
        //Admin ekranında yapmış oldugum ekleme işlemi için oluşturdugum methoddur
        [HttpPost]
        public IActionResult AddClothing([FromBody] ClothingDTO clothing)
        {
            try
            {
                Clothing newclothing = new Clothing()
                {
                    ID=clothing.ClothingID,
                    Name=clothing.Name,
                    ClothesArtUrl=clothing.ClothingArtUrl,
                    Stock=clothing.Stock,
                    Price=clothing.Price,
                    CategoryID=clothing.CategoryID,
                    BrandID=clothing.BrandID
                };
                clothingBLL.Insert(newclothing);
                return Ok(new { message = "Clothing is added", check = true });
            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check =false });
            }
        }
        //Admin ekranında yapmış oldugum update işlemi için oluşturdugum methoddur
        [HttpPost]
        public IActionResult UpdateClothing([FromBody] ClothingDTO clothingDTO)
        {
            try
            {
                Clothing clothing = clothingBLL.Get(clothingDTO.ClothingID);

                clothing.ID = clothingDTO.ClothingID;
                clothing.Name = clothingDTO.Name;
                clothing.Stock = clothingDTO.Stock;
                clothing.Price = clothingDTO.Price;
                clothing.CategoryID = clothingDTO.CategoryID;
                clothing.BrandID = clothingDTO.BrandID;
                
                if (clothingDTO.ClothingArtUrl!=null)
                {
                    clothing.ClothesArtUrl = clothingDTO.ClothingArtUrl;
                }
                clothingBLL.Update(clothing);
                return Ok(new { message = "Clothing is Updated", check = true });
            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = false });
            }
        }
        //Admin ekranında yapmış oldugum silme işlemi için oluşturdugum methoddur
        [HttpGet("{id}")]
        public IActionResult DeleteClothingById(int id)
        {
            clothingBLL.DeleteByID(id);
            return Ok(new { message = "Clothing is delete", check = true });
        }


    }
}
