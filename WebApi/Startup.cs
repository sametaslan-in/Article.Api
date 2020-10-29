using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article_Api.Business.Abstract;
using Article_Api.Business.Concrete;
using Article_Api.DataAccess.Abstract;
using Article_Api.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IArticle_ApiService, Article_ApiManager>();
            services.AddSingleton<IArticle_ApiRepositoy,Article_ApiRepositoy >();
            services.AddSwaggerDocument(configure=> {
                configure.PostProcess = (doc =>
                  {
                      doc.Info.Title = "All Article Api For Digiturk";
                      doc.Info.Version = "1.0.1";
                      doc.Info.Contact = new NSwag.OpenApiContact()
                      {
                          Name = "Samet Aslan",
                          Url = "https://www.linkedin.com/in/ssametaslan/",
                          Email = "sametaslan.in@gmail.com",



                      };

                  });
            
            
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
      
            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
