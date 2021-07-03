using System;
using System.Text;

namespace StyleCop
{
    internal class Result
    {
        public Result()
        {
        }

        public Result(bool status)
        {
            Status = status;
            ErrorMessage = string.Empty;
        }

        public Result(bool status, string errorMessage)
        {
            Status = status;
            ErrorMessage = errorMessage;
        }

        public bool Status { get; private set; }
        public string ErrorMessage { get; private set; }
    }
}
