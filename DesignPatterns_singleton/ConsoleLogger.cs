using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_singleton
{
    internal class ConsoleLogger : ILogger
    {
        private static readonly Lazy<ConsoleLogger> lazyInstance = new Lazy<ConsoleLogger>(() => new ConsoleLogger());
        private static readonly object _Lock = new object();
        
        private ConsoleLogger() {
            Console.WriteLine("Console logger created!");
        }

        public static ConsoleLogger GetInstance()
        {
            return lazyInstance.Value;
        }

        public void LogInfo(string message)
        {
            lock (_Lock)
            {
                Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
            }
        }

        public void LogWarning(string message)
        {
            lock (_Lock)
            {
                Console.WriteLine($"[WARNING] {DateTime.Now}: {message}");
            }
        }

        public void LogError(string message)
        {
            lock (_Lock)
            {
                Console.WriteLine($"[ERROR] {DateTime.Now}: {message}");
            }
        }
    }
}
