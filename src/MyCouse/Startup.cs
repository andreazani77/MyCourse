using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCouse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //solo per ambiente di produzione reindirizzo tutte le richieste ad https
            if (env.IsProduction())
            {
                app.UseHttpsRedirection();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
                //http://www.miosito.it/products?id=1
                /*await context.Response.WriteAsync(context.Request.Host.ToString()); //www.miosito.it
                await context.Response.WriteAsync(context.Request.Path.ToString()); //products
                await context.Response.WriteAsync(context.Request.Query["id"].ToString()); //1*/

            });
        }
    }
}
