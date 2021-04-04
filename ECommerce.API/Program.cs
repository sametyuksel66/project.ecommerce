using Autofac;
using Autofac.Extensions.DependencyInjection;
//using ECommerce.BLL.DependencyResolvers.Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.UseServiceProviderFactory(new AutofacServiceProviderFactory())
                //.ConfigureContainer<ContainerBuilder>(builder =>
                //{
                //    builder.RegisterModule(new AutofacBusinessModule());
                //})

                //.ConfigureWebHost(x => x.UseUrls("http://localhost:5000", "http://localhost:5001")) //sy default port belirlemek icin denedik


                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    //webBuilder.UseUrls("http://localhost:5001"); //sy default port belirlemek icin denedik
                });
    }
}
