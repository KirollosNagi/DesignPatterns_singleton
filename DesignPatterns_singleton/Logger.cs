using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_singleton
{
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _instanceLock = new object();
        
        private Logger() {
            Console.WriteLine("logger created!");
        }

        public static Logger getInstance()
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            lock (_instanceLock)
            {
                Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
            }
        }
    }
}
