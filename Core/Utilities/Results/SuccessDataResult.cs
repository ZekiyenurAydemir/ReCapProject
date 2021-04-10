using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> :DataResult<T>
    {
        //Bu versiyon data,  işlem sonucu true dur ,mesaj döndürür
        public SuccessDataResult(T data, string message)
            : base(data, true, message)
        {

        }
        //bu versiyon data ve işlem sonucu true dur, mesaj yoktur
        public SuccessDataResult(T data)
          : base(data, true)
        {

        }
        //bu versiyon data yı default (çalıştığın T nin default olan hali)verir ve mesaj verir, işlem sonucu true dur
        public SuccessDataResult(string message)
        : base(default, true, message)
        {

        }
        //bu versiyon data defaulttur ,işlem sonucu true dur,mesaj yoktur
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
