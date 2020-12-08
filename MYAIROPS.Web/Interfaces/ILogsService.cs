using MYAIROPS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYAIROPS.Web.Interfaces
{
    public interface ILogsService
    {
       void AddLog(Log log);
    }
}
