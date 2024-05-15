//==================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use Comfrom and Peace
//==================================================

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Shenneman.Api.Broker.Storages;

namespace Shenneman.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;


        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var apiInfo = new OpenApiInfo()
            {
                Title = "Shenneman.Api",
                Version = "v1"
            };

            services.AddControllers();
            services.AddDbContext<StorageBroker>();
            services.AddTransient<IStorageBroker, StorageBroker>();

            services.AddSwaggerGen(Options =>
            {
                Options.SwaggerDoc(
                    name: "v1",
                   info: apiInfo);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment Enveriment)
        {
            if (Enveriment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(Config => Config.SwaggerEndpoint(
                   url: "/swagger/v1/swagger.json",
                   name: "Shenneman.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());
        }
    }
}
