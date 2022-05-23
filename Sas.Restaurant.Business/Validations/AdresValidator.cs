using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class AdresValidator: AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(c => c.Il).MaximumLength(30).WithMessage("İl bilgisi 30 karakterden fazla olamaz");
        }
    }
}
