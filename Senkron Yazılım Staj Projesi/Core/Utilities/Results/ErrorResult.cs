using System;
using System.Collections.Generic;
using System.Text;

namespace TenderSystem.Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult()
        {
            Success = false;
        }
        public ErrorResult(string message)
        {
            Success = false;
            Message = message;
        }
        public ErrorResult(object data, string message)
        {
            Data = data;
            Success = false;
            Message = message;
        }

        public object Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
