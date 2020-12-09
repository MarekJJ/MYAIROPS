using System;
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
            this._logsService = logsService;
        }

        [HttpPost]
        [Route("addlog")]
        public ActionResult AddLog(LogDto log)
        {
            try
            {
                _logsService.AddLog(log);
            }
            catch
            {
                throw new Exception("Not able to add log: " + log.Id + ", " + log.Text + ", " + log.Date);
            }
            return Ok("Log added: " + log.Id + ", " + log.Text + ", " + log.Date);
        }
        //PostMan url: https://localhost:44377/api/logs/addLog
        //{
        // "Id":1,
        // "Text":"From text field",
        // "Date": "2020-11-05T20:56:48.56"
        //}

        //For test:
        //{
        //"Id":1,
        //"Text":"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
         // "Date": "2020-11-05T20:56:48.56"
        //}
    }
}