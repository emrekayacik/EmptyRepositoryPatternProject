using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Data.Abstract;
using Project.Data.Concrete.EF;
using Project.Data.Concrete.SQL;

namespace Project.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, EFProductRepository>(); // servis kullanmak için

            services.AddScoped<IProductRepository, SQLProductRepository>(); // servis kullanmak için
            services.AddScoped<ICategoryRepository, SQLCategoryRepository>(); // servis kullanmak için
            services.AddScoped<IOrderRepository, SQLOrderRepository>(); // servis kullanmak için

            services.AddControllersWithViews(); // controller ve view'ları kullanmak icin
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); // wwwroot için

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
