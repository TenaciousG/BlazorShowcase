using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScorD.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("ScorD.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ScorD.ServerAPI"));

            builder.Services.AddMsalAuthentication(options =>
            {
                builder.Configuration.Bind("AzureAdB2C", options.ProviderOptions.Authentication);
                options.ProviderOptions.DefaultAccessTokenScopes.Add("https://glensb2cdomain.onmicrosoft.com/a29fae80-0903-42ba-a9bc-721989d6b9dd/API.Access"); 
                //options.ProviderOptions.DefaultAccessTokenScopes.Add("https://glensb2cdomain.onmicrosoft.com/glensb2cdomain.onmicrosoft.com/a29fae80-0903-42ba-a9bc-721989d6b9dd/API.Access"); //feiler
                //options.ProviderOptions.DefaultAccessTokenScopes.Add("https://glensb2cdomain.onmicrosoft.com/API.Access");
                //options.ProviderOptions.DefaultAccessTokenScopes.Add("https://glensb2cdomain.onmicrosoft.com/glensb2cdomain.onmicrosoft.com/API.Access");
                //additional scopes can be added for additional API apps as needed.

                //override default popup login mode if desired:
                //options.ProviderOptions.LoginMode = "redirect";
            });

            await builder.Build().RunAsync();
        }
    }
}
