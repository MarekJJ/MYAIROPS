using MYAIROPS.Web.Interfaces;
using MYAIROPS.Web.Models;
using System;
using System.IO;


namespace MYAIROPS.Web.Services
{
    public class LogsService : ILogsService
    {
        public void AddLog(LogDto log)
        {
            using (TextWriter stream = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "Logs.txt"), true))
            {
                stream.Write("\n--------------\n");
                stream.Write("Id " +log.Id + "\n");
                stream.Write("Text " + log.Text + "\n");
                stream.Write("Date " + log.Date + "\n");              
                stream.Close();
            }            
        }
    }
}
