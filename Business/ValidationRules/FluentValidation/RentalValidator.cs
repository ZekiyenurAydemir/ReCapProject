using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator :AbstractValidator<Rental>
    {
        //Müşteri ve Araba alanları boş olamaz
        //Teslim edilmemiş araçlar yeniden kiralanamaz
        //ReturnDate null ise araba teslim edilmemiştir.
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();           
          //  RuleFor(r => r.ReturnDate).NotEmpty();
            RuleFor(r => r.ReturnDate).GreaterThanOrEqualTo(r => r.RentalStartDate).When(r => r.ReturnDate.HasValue);
        }
    }
}
