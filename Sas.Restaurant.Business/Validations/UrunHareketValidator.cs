using FluentValidation;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Validations
{
   public class UrunHareketValidator: AbstractValidator<UrunHareket>
    {
        public UrunHareketValidator()
        {
            RuleFor(c => c.Indirim).ScalePrecision(2, 5).WithMessage("İndirim istenilen aralıkta değil");
            RuleFor(c => c.Miktar).ScalePrecision(3,8).WithMessage("Miktar istenilen aralıkta değil");
        }
    }
}
