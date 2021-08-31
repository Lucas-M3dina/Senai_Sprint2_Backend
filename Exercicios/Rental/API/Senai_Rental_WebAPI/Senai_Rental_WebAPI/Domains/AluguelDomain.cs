using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Domains
{
    public class AluguelDomain
    {
        public int idAluguel;
        public VeiculoDomain veiculo;
        public ClienteDomain cliente;
        public DateTime dataRetirada;
        public DateTime dataDevolucao;
    }
}
