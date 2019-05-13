using Microsoft.AspNetCore.Blazor.Hosting;

namespace UtaFormatOL.Blazor
{
    public class Program
    {
        public const string Title = "UtaFormatOL";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
