using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using System.Linq;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace ScorD.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAdB2C")); //protect the web api with Microsoft Identity Platform
            
            services.AddAuthorization(options =>
            {
                //All calls to the server webAPI must have scope API.Access
                options.DefaultPolicy = new AuthorizationPolicyBuilder().RequireClaim(ClaimConstants.Scope, "API.Access")
                    .Build();

                //optional access policies for selected endpoints
                options.AddPolicy("RequireForecastAccess",
                    policy => policy.RequireClaim("Permission", "CanCheckForecast", "CanCheckEverything"));
            });

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                //configure to use proper name claim
                options.TokenValidationParameters.NameClaimType = "name";

                options.TokenValidationParameters.IssuerValidator = ValidateSpecificIssuers;
            });
        }

        private string ValidateSpecificIssuers(string issuer, SecurityToken securityToken,
            TokenValidationParameters validationParameters)
        {
            //bug in ValidateIssuers in current asp.net version forces override of validation, otherwise it fails with: 
            //Microsoft.IdentityModel.Tokens.SecurityTokenInvalidIssuerException: 'IDW10303:  ..does not match any of the valid issuers provided for this application
            // solution from: https://github.com/AzureAD/microsoft-identity-web/issues/168
            var myAdInstance = Configuration.GetSection("AzureAdB2C").GetSection("Instance").Value;
            var myAdInstanceHost = new Uri(myAdInstance).Host;

            var issuerUri = new Uri(issuer);

            if (issuerUri.Host.Equals(myAdInstanceHost, StringComparison.InvariantCultureIgnoreCase))
            {
                return issuer;
            }
            else
            {
                throw new SecurityTokenInvalidIssuerException("The token issuer is not valid here.");
            }
        }
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
