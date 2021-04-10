﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    //validation kuralları yazıyoruz -doğrulama
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.DailyPrice).NotEmpty();
            RuleFor(c=>c.DailyPrice).GreaterThan(0);
        }
    }
}
