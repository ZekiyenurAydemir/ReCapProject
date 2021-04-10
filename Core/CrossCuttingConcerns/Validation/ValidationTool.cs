using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{   //AOP NEDİR?
    //uygulanın başında,sonunda  ve ya hata olduğunda
    //çalışmasını istedğimiz kodlar varsa bunları AOP kullarak design edebilirz
    public class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
