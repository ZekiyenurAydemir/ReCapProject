using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            //MArka ismi boş olmayacak
            RuleFor(b => b.BrandName).NotEmpty();
            //Marka Adı En az 3 Karaker olmalı
            RuleFor(b => b.BrandName).MinimumLength(3);
        }
    }
}
