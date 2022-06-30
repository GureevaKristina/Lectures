using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BasicC
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
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World");
            //});
            //int y = 2;
            //int u = 3;
            //int t = 4;
            //int rez = 0;

            //app.Use(async (context, next) =>
            //{
            //    rez = y * u + t;
            //    await next.Invoke();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync($"Rus : {rez}");
            //});

            app.Map("/firstpage", FirstPage);

            app.Map("/secondpage", SecondPage);

            app.MapWhen(t =>
            {
                return t.Request.Query.ContainsKey("key")                &&
                t.Request.Query["key"] == "10";
            }, IsHandle);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Page not found");
            });

            //////////////////////////////////////////////////////
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
        }

        private static void FirstPage(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"First page");
            });
        }
        private static void SecondPage(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Second page");
            });
        }
        private static void IsHandle(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"id is equal to 10");
            });
        }
    }
}
