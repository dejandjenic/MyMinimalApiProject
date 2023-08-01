using Google.Cloud.Functions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MyMinimalApiProject;

namespace MyMinimalApiProject
{
    public class Startup : FunctionsStartup
    {

        public override void Configure(WebHostBuilderContext context, IApplicationBuilder app)
        {
            base.Configure(context, app);

            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/pow/{baseNum}/{pow}", (IMathService service, int baseNum, int pow) => service.Pow(baseNum, pow))
                .WithName("Pow")
                .WithOpenApi();

                endpoints.MapGet("/sqrt/{baseNum}", (IMathService service, long baseNum) => service.Sqrt(baseNum))
                .WithName("Sqrt")
                .WithOpenApi();
            }
            );

        }


        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
        {
            base.ConfigureServices(context, services);

            services.AddScoped<IMathService, MathService>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }
    }
}