using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class MasaValidator:AbstractValidator<Masa>
    {
        public MasaValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(30).WithMessage("Adı 30 karakterden fazla olamaz");
        }
    }
}
