using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYAIROPS.Web.Interfaces;

namespace MYAIROPS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private ILogsService _logsService;
        public DefaultController(ILogsService logsService)
        {
            ILogsService _logsService = logsService;
        }

    }
}