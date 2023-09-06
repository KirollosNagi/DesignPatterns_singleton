using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_singleton
{
    public class Logger
    {
        private static readonly Lazy<Logger> lazyInstance = new Lazy<Logger>(() => new Logger());
        private static readonly object _Lock = new object();
        
        private Logger() {
            Console.WriteLine("logger created!");
        }

        public static Logger getInstance()
        {
            return lazyInstance.Value;
        }

        public void Log(string message)
        {
            lock (_Lock)
            {
                Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
            }
        }
    }
}
