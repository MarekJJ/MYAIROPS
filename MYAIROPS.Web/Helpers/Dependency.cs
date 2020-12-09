using Microsoft.Extensions.DependencyInjection;
using MYAIROPS.Web.Interfaces;
using MYAIROPS.Web.Services;

namespace MYAIROPS.Web.Helpers
{
    public static class Dependency
    {
        public static void Injector(IServiceCollection services)
        {
             services.AddScoped<ILogsService, LogsService>();
        }
    }
}
