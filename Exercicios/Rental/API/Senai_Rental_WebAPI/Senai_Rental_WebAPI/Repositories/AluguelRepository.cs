using Senai_Rental_WebAPI.Domains;
using Senai_Rental_WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Repositories
{
    public class AluguelRepository : IAluguelRepository
    {
        private string stringConexao = "Data Source=NOTE0113G2\\SQLEXPRESS; initial catalog=CATALOGO_M; user id=sa; pwd=Senai@132";

        public void Atualizar(int idAluguel, AluguelDomain AluguelAtualizado)
        {
            throw new NotImplementedException();
        }

        public AluguelDomain BuscarPorId(int idAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT nomeGenero, idGenero FROM GENERO WHERE idGenero = @idGenero";

                con.Open();

                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    cmd.Parameters.AddWithValue("@idAluguel", idAluguel);

                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        AluguelDomain AluguelBuscado = new AluguelDomain
                        {
                            idAluguel = Convert.ToInt32(reader["idAluguel"]),

                          ///  nomeGenero = reader["nomeGenero"].ToString()
                        };

                        return AluguelBuscado;
                    }

                    return null;
                }
            }
        }

        public void Deletar(int idAluguel)
        {
            throw new NotImplementedException();
        }

        public void Inserir(AluguelDomain novoAluguel)
        {
            throw new NotImplementedException();
        }

        public List<AluguelDomain> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
