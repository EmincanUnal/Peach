using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Peach.UI.MVC.Areas.Admin.Helpers
{
    public class ImgHelpers
    {
        [Obsolete]
        public static string GetImageUrl(IFormFile file, IHostingEnvironment environment)
        {
            string picture = Path.Combine(environment.WebRootPath, "img/products");
            string newName = string.Empty;
            if (file != null)
            {
                string dosya = file.FileName;
                string[] dosyaArray = dosya.Split('.');
                newName = Guid.NewGuid().ToString() + "." + dosyaArray[dosyaArray.Length - 1];

                using (var fileStream = new FileStream(Path.Combine(picture, newName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return "/img/products/" + newName;
        }
    }
}
