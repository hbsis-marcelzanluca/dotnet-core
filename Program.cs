using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using NancyConfigs;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando aplicação Nancy...");

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
 
            Console.WriteLine("Aplicação Nancy rodando!");
            host.Run();
        }
    }
}
