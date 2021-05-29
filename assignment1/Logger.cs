using System;

namespace assignment1
{
    public class Logger
    {
        private static Logger _loggerInstance;
        private int _numberOfLines;

        private Logger()
        {
            _numberOfLines = 1;
        }

        public static Logger GetInstance()
        {
            return _loggerInstance ??= new Logger();
        }

        public void Log(string className, string message)
        {
            Console.WriteLine($"{_numberOfLines++} - [{className}] {message}");
        }
    }
}