using System;
using System.Text;

namespace StyleCop
{
    internal class Starter
    {
        public void Run()
        {
            var action = new Actions();
            var maxIter = 100;
            var maxValue = 3;
            var random = new Random();
            var result = new Result(false);
            for (var i = 0; i < maxIter; i++)
            {
                switch (random.Next(maxValue))
                {
                    case 0:
                        result = action.Method_1();
                        break;
                    case 1:
                        result = action.Method_2();
                        break;
                    case 2:
                        result = action.Method_3();
                        break;
                }

                if (result.Status == false)
                {
                    Logger.Instance.Write(LogType.Error, $"Action failled by a reason: {result.ErrorMessage}");
                }
            }

            Logger.Instance.ToFile();
        }
    }
}
