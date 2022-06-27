using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class UrunNotValidator:AbstractValidator<UrunNot>
    {
        public UrunNotValidator()
        {
            RuleFor(c => c.Notu).MaximumLength(100).WithMessage("Notunuz 100 karakterden fazla olamaz");
            RuleFor(c => c.Notu).NotEmpty().WithMessage("Ürün notu boş geçilemez");
        }
    }
}
