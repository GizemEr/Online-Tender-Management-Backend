using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TenderSystem.Business.Abstract;
using TenderSystem.Business.Concrete;
using TenderSystem.Core.Utilities.RandomNumberGenerator;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.DataAccess.Concrete.EntityFramework;

namespace TenderSystemProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(); //To use MVC 

            services.AddCors();

            //Abstract - Concrete Pairing!
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IAddressDal, EfAddressDal>();
          
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAdminDal, EfAdminDal>();

            services.AddScoped<IBidService, BidManager>();
            services.AddScoped<IBidDal, EfBidDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IClientService, ClientManager>();
            services.AddScoped<IClientDal, EfClientDal>();

            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<IImageDal, EfImageDal>();

            services.AddScoped<ITenderService, TenderManager>();
            services.AddScoped<ITenderDal, EfTenderDal>();

            services.AddScoped<ITenderStatusService, TenderStatusManager>();
            services.AddScoped<ITenderStatusDal, EfTenderStatusDal>();

            services.AddScoped<IRandomNumberGenerator, RandomNumberGenerator>();

            //services.AddScoped<IUserService, UserManager>();
            //services.AddScoped<IUserDal, EfUserDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder=>builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}