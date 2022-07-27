using System;
using System.Collections.Generic;
using System.Text;

namespace TenderSystem.Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult()
        {
            Success = true;
        }
        public SuccessResult(string message)
        {
            Success = true;
            Message = message;
        }
        public SuccessResult(object data, string message)
        {
            Data = data;
            Success = true;
            Message = message;
        }

        public object Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

    }
}
