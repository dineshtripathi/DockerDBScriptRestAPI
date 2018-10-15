using ConferenceApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConferenceApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=10.0.75.1,1433;Database=DockerDBTest;User=sa;Password=Your_password123;";

          //  var connectionString = Configuration.GetConnectionString("DbConnection");
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<ConferenceContext>((serviceProvider, options) => options.UseSqlServer(connection).UseInternalServiceProvider(serviceProvider)

                ).AddDbContext<ConferenceContext>(ServiceLifetime.Singleton);                
            services.AddMvc();
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownProxies.Add(System.Net.IPAddress.Parse("10.0.0.100"));
            });
            services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }
            var forwardOptions = new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto,
                RequireHeaderSymmetry = false
            };

           // forwardOptions.KnownNetworks.Clear();
           // forwardOptions.KnownProxies.Clear();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData.Initialize(serviceScope.ServiceProvider);
            }

            // Seeder.SeedDatabase(app.ApplicationServices);
        }
    }
}
