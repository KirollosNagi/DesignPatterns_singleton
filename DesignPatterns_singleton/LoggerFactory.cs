using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_singleton
{
    public class LoggerFactory
    {

        public static ILogger GetConsoleLogger()
        {
            return ConsoleLogger.GetInstance();
        }

        public static ILogger GetFileLogger(string logFileName)
        {
            return FileLogger.GetInstance(logFileName);
        }
    }
}
