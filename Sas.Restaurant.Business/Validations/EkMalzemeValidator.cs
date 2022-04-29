using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class EkMalzemeValidator: AbstractValidator<EkMalzeme>
    {
        public EkMalzemeValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Adı alanı boş geçilemez");
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı bilgisi 50 karakterden fazla olamaz");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat bilgisi aralık dışında");
        }
    }
}
