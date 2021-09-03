using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Domains
{
    public class VeiculoDomain
    {
        public int idVeiculo { get; set; }
        public EmpresaDomain empresa { get; set; }
        public ModeloDomain modelo { get; set; }
        public string corVeiculo { get; set; }
    }
}
