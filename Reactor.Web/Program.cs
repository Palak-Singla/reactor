﻿using System.IO.Compression;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;

namespace Reactor.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddResponseCompression();
                    services.Configure<GzipCompressionProviderOptions>(options =>
                    {
                        options.Level = CompressionLevel.Optimal;
                    });
                })
                .UseStartup<Startup>()
                .Build();
    }
}