using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        //Müşteri Adı boş olmamalı ve en az 4 karakter olmalıdır.
        //UserId boş olmamalıdır.
        public CustomerValidator()
        {
            RuleFor(c=>c.CompanyName).NotEmpty();
            RuleFor(c=>c.CompanyName).MinimumLength(4);
            RuleFor(c => c.UserId).NotEmpty();
        }
    }
}
