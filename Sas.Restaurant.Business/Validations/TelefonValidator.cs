using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class TelefonValidator: AbstractValidator<Telefon>
    {
        public TelefonValidator()
        {
            RuleFor(c => c.Telefonu).MaximumLength(20).WithMessage("Telefon bilgisi 20 karakterden fazla olamaz");
        }
    }
}
