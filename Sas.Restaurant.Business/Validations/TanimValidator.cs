using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class TanimValidator: AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Tanim bilgisi 50 karakterden fazla olamaz");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Tanim bilgisi boş geçilemez");
        }
    }
}
