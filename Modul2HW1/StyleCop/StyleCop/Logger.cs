using System;
using System.Text;
using System.IO;

namespace StyleCop
{
    internal class Logger
    {
        private static readonly Logger _instance = new Logger();
        private StringBuilder _logs;

        static Logger()
        {
        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Write(LogType type, string message)
        {
            var log = $"{DateTime.UtcNow}: {type.ToString()}: {message}";
            _logs.AppendLine(log);
            Console.WriteLine(log);
        }

        public void ToFile()
        {
            File.WriteAllText("log.txt", _logs.ToString());
        }
    }
}
