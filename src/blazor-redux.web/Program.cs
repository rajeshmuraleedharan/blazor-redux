using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Fluxor;
using Fluxor.Blazor.Web.Middlewares;
namespace BlazorRedux
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            ConfigureFluxor(builder);

            await builder.Build().RunAsync();
        }

        private static void ConfigureFluxor(WebAssemblyHostBuilder builder)
        {
            var currentAssembly = typeof(Program).Assembly;
            builder.Services.AddFluxor(options =>
            {
                options.ScanAssemblies(currentAssembly);
                options.UseReduxDevTools();
                options.UseRouting();
            });
        }
    }
}
