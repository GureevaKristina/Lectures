using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture_2
{
    public class Startup
    {
        //public void ConfigureServices(IServiceCollection services)
        //{

        //}
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    app.UseRouting();

        //    app.UseEndpoints(endoint =>
        //    {
        //        endoint.MapGet("/", async context =>
        //        {
        //            await context.Response.WriteAsync("Hello W");
        //        });
        //        endoint.MapGet("/index", async context =>
        //        {
        //            await context.Response.WriteAsync("Hello Index");
        //        });
        //        endoint.MapGet("/error", async context =>
        //        {
        //            await context.Response.WriteAsync("Error");
        //        });
        //    });
        //}

        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }

        //    app.UseRouting();
        //    app.Use(async (context, next) =>
        //    {
        //        // �������� �������� �����
        //        Endpoint endpoint = context.GetEndpoint();

        //        if (endpoint != null)
        //        {
        //            // �������� ������ ��������, ������� ������������ � �������� ������
        //            var routePattern = (endpoint as Microsoft.AspNetCore.Routing.RouteEndpoint)?.RoutePattern?.RawText;

        //            Debug.WriteLine($"Endpoint Name: {endpoint.DisplayName}");
        //            Debug.WriteLine($"Route Pattern: {routePattern}");

        //            // ���� �������� ����� ����������, �������� ��������� ������
        //            await next();
        //        }
        //        else
        //        {
        //            Debug.WriteLine("Endpoint: null");
        //            // ���� �������� ����� �� ����������, ��������� ���������
        //            await context.Response.WriteAsync("Endpoint is not defined");
        //        }
        //    });
        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapGet("/index", async context =>
        //        {
        //            await context.Response.WriteAsync("Hello Index!");
        //        });
        //        endpoints.MapGet("/", async context =>
        //        {
        //            await context.Response.WriteAsync("Hello World!");
        //        });
        //    });
        //}

        //public void Configure(IApplicationBuilder app)
        //{
        //    // ���������� ���������� ��������
        //    var myRouteHandler = new RouteHandler(Handle);
        //    // ������� �������, ��������� ����������
        //    var routeBuilder = new RouteBuilder(app, myRouteHandler);
        //    // ���� ����������� �������� - �� ������ ��������������� ������� {controller}/{action}
        //    routeBuilder.MapRoute("default", "{controller}/{action}");
        //    // ������ �������
        //    app.UseRouter(routeBuilder.Build());

        //    app.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Hello World!");
        //    });
        //}

        //// ���������� ���������� ��������
        //private async Task Handle(HttpContext context)
        //{
        //    await context.Response.WriteAsync("Hello Infopulse! :) ");
        //}

        public void Configure(IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);

            routeBuilder.MapRoute("{controller}/{action}",
                async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("�������������� ������");
                });


            routeBuilder.MapRoute("{controller}/{action}/{id?}",
                async context => {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("�������������� ������");
                });

            app.UseRouter(routeBuilder.Build());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
