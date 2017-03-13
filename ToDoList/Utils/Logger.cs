using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace ToDoList.Utils
{
    public class Logger : ILogger
    {
        private ILog log4net_logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Log(string data)
        {
            log4net_logger.Debug(data);
        }
    }
}