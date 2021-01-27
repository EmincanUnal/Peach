using Microsoft.Extensions.DependencyInjection;
using Peach.BLL.Abstract;
using Peach.DAL.Concrete.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peach.BLL.Concrete.DependencyInjection
{
   public static class EFContextBLL
    {
        public static void AddScopedBLL(this IServiceCollection services)
        {
            services.AddScopedDAL();//Startupda çağrıldıgında Dalda newlenecek ve bu sayede katmanlar arası bağlantı saglanıyor
            services.AddScoped<IClothingBLL, ClothingService>();
            services.AddScoped<IBrandBLL, BrandService>();
            services.AddScoped<ICategoryBLL, CategoryService>();
            services.AddScoped<IOrderBLL, OrderService>();
            services.AddScoped<IUserBLL, UserService>();
        }
    }
}
