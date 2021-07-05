using System;
using System.Text;
using System.IO;

namespace StyleCop
{
    public class Starter
    {
        private Actions _action = new Actions();
        public void Run()
        {
            const int maxValue = 3;
            var random = new Random();
            var result = new Result();
            for (var i = 0; i < 100; i++)
            {
                switch (random.Next(maxValue))
                {
                    case 0:
                        result = _action.Method_1();
                        break;
                    case 1:
                        result = _action.Method_2();
                        break;
                    case 2:
                        result = _action.Method_3();
                        break;
                }

                if (!result.Status)
                {
                    Logger.Instance.Write(LogType.Error, $"Action failled by a reason: {result.ErrorMessage}");
                }
            }

            File.WriteAllText("log.txt", Logger.Instance.ReturnLogs());
        }
    }
}
