using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYAIROPS.Web.Interfaces;
using MYAIROPS.Web.Models;

namespace MYAIROPS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private readonly ILogsService _logsService;
        public LogsController(ILogsService logsService)
        {
            ILogsService _logsService = logsService;
        }

        [HttpPost("{log}")]
        public ActionResult AddLog(Log log)
        {
            throw new System.NotImplementedException();
        }

    }
}