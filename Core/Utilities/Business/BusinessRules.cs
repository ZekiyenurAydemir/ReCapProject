using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //logic  : iş kuralı demek
        public static IResult Run(params IResult[] logics)//parametre ile gönderilen iş kuralları
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)//iş kuralı başarısız ise
                {
                    return logic; //ErrorResult döndürücek
                }
            }
            return null;
        }
    }
}
