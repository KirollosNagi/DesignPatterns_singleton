using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_singleton
{
    internal class FileLogger : ILogger, IDisposable
    {
        private string logFilePath;
        private StreamWriter logWriter;
        private static FileLogger instance;
        private static readonly object _Lock = new object();


        private FileLogger(string logFilePath)
        {
            this.logFilePath = logFilePath;
            logWriter = new StreamWriter(logFilePath, true, Encoding.UTF8);
            Console.WriteLine($"Logger created using file: {logFilePath}");
        }

        public static FileLogger GetInstance(string logFilePath)
        {
            if (instance == null)
            {
                lock (_Lock)
                {
                    if (instance == null)
                    {
                        instance = new FileLogger(logFilePath);
                    }
                }
            }
            return instance;
        }

        public void LogInfo(string message)
        {
            Log("INFO", message);
        }

        public void LogWarning(string message)
        {
            Log("WARNING", message);
        }

        public void LogError(string message)
        {
            Log("ERROR", message);
        }

        private void Log(string logLevel, string message)
        {
            string logEntry = $"{DateTime.Now} [{logLevel}] - {message}";
            lock (_Lock)
            {
                logWriter.WriteLine(logEntry);
                logWriter.Flush(); // Ensure the message is written immediately
            }
        }

        public void Dispose()
        {
            logWriter?.Dispose();
        }
    }
}
