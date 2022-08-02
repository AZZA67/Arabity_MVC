using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arabitey.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Arabitey.Repository;
using Arabitey.Hubs;

namespace Arabitey
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {



            services.AddControllersWithViews();

            services.AddSignalR();
            services.AddDbContext<EntityContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Arabety"));
            });
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IImagesRepository, ImagesRepository>();
            services.AddScoped<ICarBrandRepository, CarBrandRepository>();
            services.AddScoped<ICarModelYearRepository, CarModelYearRepository>();
            services.AddScoped<ICarModelNameRepository, CarModelNameRepository>();







            services.AddIdentity<ApplicationUser, IdentityRole>(
           //option => {
           //    option.Password.RequireUppercase = false;
           //    option.Password.RequiredLength = 4;
           //    option.Password.RequireDigit = false;
           //}
           )
               .AddEntityFrameworkStores<EntityContext>();
            services.AddSession(sessionoptions => {
                sessionoptions.IdleTimeout = TimeSpan.FromMinutes(10);

            });
        }
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<CommentHub>("CommentHub");
                endpoints.MapHub<NotificationHub>("NotificationHub");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
