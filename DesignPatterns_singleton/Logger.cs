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
        
        private Logger() {
            Console.WriteLine("logger created!");
        }
        public static Logger getInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }



    }
}
