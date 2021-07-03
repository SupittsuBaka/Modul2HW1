using System;
using System.Text;

namespace StyleCop
{
    internal class Actions
    {
        private readonly Logger _logger = Logger.Instance;
        public Result Method_1()
        {
            _logger.Write(LogType.Info, "Start method:");
            return new Result(true);
        }

        public Result Method_2()
        {
            _logger.Write(LogType.Warning, "Skipped logic in method:");
            return new Result(true);
        }

        public Result Method_3()
        {
            return new Result(false, "I broke a logic");
        }
    }
}
