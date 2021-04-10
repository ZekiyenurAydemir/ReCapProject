using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //Bu versiyon data,  işlem sonucu false dur ,mesaj döndürür
        public ErrorDataResult(T data, string message)
            : base(data, false, message)
        {

        }
        //bu versiyon data ve işlem sonucu false dur, mesaj yoktur
        public ErrorDataResult(T data)
          : base(data, false)
        {

        }
        //bu versiyon data yı default (çalıştığın T nin default olan hali)verir ve mesaj verir, işlem sonucu false dur
        public ErrorDataResult(string message)
        : base(default, false, message)
        {

        }
        //bu versiyon data defaulttur ,işlem sonucu false dur,mesaj yoktur
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
