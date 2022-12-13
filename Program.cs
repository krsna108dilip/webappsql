using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webappsql
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
                webBuilder.ConfigureAppConfiguration(config =>
                {
                    config.Build();
                    config.AddAzureAppConfiguration("Endpoint=https://appconfigdemo100.azconfig.io;Id=zkN1-lh-s0:Cf0ZnASkcIIyS2W5oNDD;Secret=pfvYAcNA8kDOXl0KsW+OanAsnTqKlNK7COqwhbSix80=");
                    //webBuilder.UseStartup<Startup>();
                })
                .UseStartup<Startup>());
        //            .ConfigureWebHostDefaults(webBuilder =>
        //            {
        //                webBuilder.UseStartup<Startup>();
        //            });
        //}
    }
}
