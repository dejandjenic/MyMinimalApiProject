using Google.Cloud.Functions.Framework;
using Google.Cloud.Functions.Hosting;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyMinimalApiProject;

[FunctionsStartup(typeof(Startup))]

public class Function : IHttpFunction
{
    public async Task HandleAsync(HttpContext context)
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Notfound");
    }
}