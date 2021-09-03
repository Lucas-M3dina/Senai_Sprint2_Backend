using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Domains
{
    public class ModeloDomain
    {
        public int idModelo { get; set; }
        public MarcaDomain marca { get; set; }
        public string nomeModelo { get; set; }
        public DateTime anoLancamento { get; set; }

    }
}
