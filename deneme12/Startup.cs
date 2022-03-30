using deneme12.Context;
using deneme12.Entity;
using deneme12.Interfaces;
using deneme12.Repostories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme12
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
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>(
                
                );
            services.AddScoped<IOgrenciRepostory, OgrenciRepostorie>();
            services.AddScoped<IOgrenciSinifRepostory, OgrenciSinifRepostory>();
            services.AddScoped<ISinifRepostory, SinifRepostory>();
            services.AddScoped<IVeliRepostory, VeliRepostory>();
            services.AddScoped<IDerslikRepostory, DerslikRepostory>();
            services.AddScoped<IDersRepostory, DersRepostory>();
            services.AddScoped<ISinifDersRepostory, SinifDersRepostory>();
            services.AddScoped<IGunSinifRepostory, GunSinifRepostory>();
            services.AddScoped<IGunRepostory, GunRepostory>();
            services.AddScoped<IDersProgamiRepostory, DersProgamiRepostory>();
            services.AddScoped<IDersProgramiListRepostory, DersProgramiListRepostory>();
            services.AddScoped<ISaatRepostory, SaatRepostory>();
            services.AddSession();

            services.AddDbContext<AppDbContext>();
            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Admin");
                opt.Cookie.Name = "EgitimPanel";
                opt.Cookie.HttpOnly = true;
                opt.Cookie.SameSite = SameSiteMode.Strict;
                opt.ExpireTimeSpan = TimeSpan.FromDays(10);
            });
           
        
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<AppUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
           app.UseSession();    

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
