using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("50 Karakterden fazla girilemez");
            RuleFor(c => c.Barkod).MaximumLength(20).WithMessage("Barkod bilgisi 20 karakterden fazla girilemez");


        }
    }
}
