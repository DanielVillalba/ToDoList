using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace ToDoList.Utils
{
    /// <summary>
    /// Implementation to be injected on the classes that requires logging functionality
    /// </summary>
    public class Logger : ILogger
    {
        private ILog log4net_logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Provides a general interface to log information to a file.
        /// </summary>
        /// <param name="rootObjec">Name of the object performing the log</param>
        /// <param name="data">Information that needs to be logged</param>
        public void Log(string rootObjec, string data)
        {
            log4net_logger.Debug("Origin: " + rootObjec + " --> " + data);
        }
    }
}