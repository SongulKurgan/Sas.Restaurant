using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class Porsiyon_Validator: AbstractValidator<Porsiyon>
    {
        public Porsiyon_Validator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Porsiyon bilgisi 50 karakterden fazla olamaz");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat bilgisi aralık dışında");
            RuleFor(c => c.EkMalzemeCarpan).ScalePrecision(2, 4).WithMessage("Çarpan bilgisi aralık dışında ");
        }
    }
}
