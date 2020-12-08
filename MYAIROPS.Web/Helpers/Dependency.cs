using Microsoft.Extensions.DependencyInjection;
using MYAIROPS.Web.Interfaces;
using MYAIROPS.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
