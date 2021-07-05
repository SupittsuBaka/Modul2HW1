using System;
using System.Text;

namespace StyleCop
{
    public class Actions
    {
        private readonly Logger _logger = Logger.Instance;
        public Result Method_1()
        {
            var result = new Result { Status = true };
            _logger.Write(LogType.Info, $"Start method:{nameof(Method_1)}");
            return result;
        }

        public Result Method_2()
        {
            var result = new Result { Status = true };
            _logger.Write(LogType.Warning, $"Skipped logic in method:{nameof(Method_2)}");
            return result;
        }

        public Result Method_3()
        {
            var result = new Result { Status = false, ErrorMessage = "I broke a logic" };
            return result;
        }
    }
}
