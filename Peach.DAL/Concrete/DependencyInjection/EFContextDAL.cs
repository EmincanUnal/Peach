using Microsoft.Extensions.DependencyInjection;
using Peach.DAL.Abstract;
using Peach.DAL.Concrete.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.DAL.Concrete.DependencyInjection
{
   public static class EFContextDAL//extension oldugu için static olarak oluşturuldu
    {
        public static void AddScopedDAL(this IServiceCollection services)//import yapabilmesi için this yazıldı
        {
            services.AddScoped<IClothingDAL, ClothingRepository>();//Çağrıldıgında ayaga kaldırıldı
            services.AddScoped<ICategoryDAL, CategoryRepository>();
            services.AddScoped<IBrandDAL, BrandRepository>();
            services.AddScoped<IOrderDAL, OrderRepository>();
            services.AddScoped<IUserDAL, UserRepository>();
        }
    }
}
