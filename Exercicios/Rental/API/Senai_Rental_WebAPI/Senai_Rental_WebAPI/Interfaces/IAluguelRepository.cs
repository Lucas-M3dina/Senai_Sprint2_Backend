using Senai_Rental_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Interfaces
{
    interface IAluguelRepository
    {
        /// <summary>
        /// Retorna todos os Aluguéis
        /// </summary>
        /// <returns>Uma lista de Aluguéis</returns>
        List<AluguelDomain> ListarTodos();

        /// <summary>
        /// Busca um Aluguel através do seu id
        /// </summary>
        /// <param name="idAluguel">Id do Aluguel que será buscado</param>
        /// <returns>Um objeto do tipo AluguelDomain que foi buscado</returns>
        AluguelDomain BuscarPorId(int idAluguel);

        /// <summary>
        /// Deleta um Aluguel
        /// </summary>
        /// <param name="idAluguel">Id do Aluguel que será deletado</param>
        void Deletar(int idAluguel);

        /// <summary>
        /// Atualiza um Aluguel existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idAluguel">id do Aluguel que será atualizado</param>
        /// <param name="AluguelAtualizado">Objeto AluguelAtualizado com os novos dados</param>
        /// ex: http://localhost:5000/api/aluguel/atualizar/3
        void Atualizar(int idAluguel, AluguelDomain AluguelAtualizado);

        /// <summary>
        /// Cadastra um novo Aluguel
        /// </summary>
        /// <param name="novoAluguel">Objeto novoAluguel com os dados que serão cadastrados</param>
        void Inserir(AluguelDomain novoAluguel);
    }
}
