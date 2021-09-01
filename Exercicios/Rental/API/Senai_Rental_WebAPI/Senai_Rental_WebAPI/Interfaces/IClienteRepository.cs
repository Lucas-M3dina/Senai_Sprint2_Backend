using Senai_Rental_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Interfaces
{
    interface IClienteRepository
    {
        /// <summary>
        /// Retorna todos os Clientes
        /// </summary>
        /// <returns>Uma lista de Clientes</returns>
        List<ClienteDomain> ListarTodos();

        /// <summary>
        /// Busca um Cliente através do seu id
        /// </summary>
        /// <param name="idCliente">Id do Cliente que será buscado</param>
        /// <returns>Um objeto do tipo ClienteDomain que foi buscado</returns>
        ClienteDomain BuscarPorId(int idCliente);

        /// <summary>
        /// Deleta um Cliente
        /// </summary>
        /// <param name="idCliente">Id do Cliente que será deletado</param>
        void Deletar(int idCliente);

        /// <summary>
        /// Atualiza um Cliente existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="idCliente">id do Cliente que será atualizado</param>
        /// <param name="ClienteAtualizado">Objeto ClienteAtualizado com os novos dados</param>
        /// ex: http://localhost:5000/api/Cliente/atualizar/3
        void Atualizar(int idCliente, ClienteDomain ClienteAtualizado);

        /// <summary>
        /// Cadastra um novo Cliente
        /// </summary>
        /// <param name="novoCliente">Objeto novoCliente com os dados que serão cadastrados</param>
        void Inserir(ClienteDomain novoCliente);
    }
}
