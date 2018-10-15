using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ConferenceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Build().Run();
        }

        public static IWebHostBuilder BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
               // .UseUrls("http://*:5000") // listen on port 5000 on all network interfaces
                .UseIISIntegration();
                
    }
}
