using Senai_Rental_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Interfaces
{
    interface IVeiculoRepository
    {
        /// <summary>
        /// Retorna todos os Veiculos
        /// </summary>
        /// <returns>Uma lista de Veiculos</returns>
        List<VeiculoDomain> ListarTodos();

        /// <summary>
        /// Busca um Veiculo através do seu id
        /// </summary>
        /// <param name="idVeiculo">Id do Veiculo que será buscado</param>
        /// <returns>Um objeto do tipo VeiculoDomain que foi buscado</returns>
        VeiculoDomain BuscarPorId(int idVeiculo);

        /// <summary>
        /// Deleta um Veiculo
        /// </summary>
        /// <param name="idVeiculo">Id do Veiculo que será deletado</param>
        void Deletar(int idVeiculo);

        /// <summary>
        /// Atualiza um Veiculo existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idVeiculo">id do Veiculo que será atualizado</param>
        /// <param name="VeiculoAtualizado">Objeto VeiculoAtualizado com os novos dados</param>
        /// ex: http://localhost:5000/api/aluguel/atualizar/3
        void Atualizar(int idVeiculo, VeiculoDomain VeiculoAtualizado);

        /// <summary>
        /// Cadastra um novo Veiculo
        /// </summary>
        /// <param name="novoVeiculo">Objeto novoVeiculo com os dados que serão cadastrados</param>
        void Inserir(VeiculoDomain novoVeiculo);
    }
}
