using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, bool success, string message)
            : base(success, message)
        {

        }
        //Mesaj olmadan sadece data ve success döndürüuoruz
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
    }
}
