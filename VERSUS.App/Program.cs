﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace VERSUS.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
.CaptureStartupErrors(true)
.UseStartup<Startup>();
        }
    }
}