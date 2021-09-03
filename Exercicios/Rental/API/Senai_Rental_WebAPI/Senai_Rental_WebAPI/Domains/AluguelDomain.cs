using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Domains
{
    public class AluguelDomain
    {
        public int idAluguel { get; set; }
        public VeiculoDomain veiculo { get; set; }
        public ClienteDomain cliente { get; set; }
        public DateTime dataRetirada { get; set; }
        public DateTime dataDevolucao { get; set; }
    }
}
