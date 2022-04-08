using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
    public class Tanim:EntityBase
    {
        public string  Adi { get; set; }
        public TanimTip TanimTip { get; set; }
    }
}
