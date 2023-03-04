using BlogApp_Shared.Utilities.Results.Abstract;
using BlogApp_Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }

        public DataResult(ResultStatus resultStatus,T data)
        {
            Data = data;
            ResultStatus = resultStatus;
        }

        public DataResult(ResultStatus resultStatus, string message,T data)
        {
            Message = message;
            Data = data;
            ResultStatus = resultStatus;
        }

        public DataResult(ResultStatus resultStatus, string message, T data,Exception exception)
        {
            Message = message;
            Data = data;
            ResultStatus = resultStatus;
            Exception = exception;
        }
    }
}
