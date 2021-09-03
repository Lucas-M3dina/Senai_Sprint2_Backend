using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_Rental_WebAPI.Domains;
using Senai_Rental_WebAPI.Interfaces;
using Senai_Rental_WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Rental_WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _ClienteRepository { get; set; }

        public ClienteController()
        {
            _ClienteRepository = new ClienteRepository();
        }

        [HttpGet]
        public IActionResult Get()
        { 
            List<ClienteDomain> listaClientes = _ClienteRepository.ListarTodos();

            return Ok(listaClientes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ClienteDomain clienteBuscado = _ClienteRepository.BuscarPorId(id);

            if (clienteBuscado == null)
            {
                return NotFound("Nenhum cliente encontrado!");
            }

            return Ok(clienteBuscado);
        }

        [HttpPost]
        public IActionResult Post(ClienteDomain novoCliente)
        {
            _ClienteRepository.Inserir(novoCliente);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult PutUrl(int id, ClienteDomain clienteAtualizado)
        {
            ClienteDomain clienteBuscado = _ClienteRepository.BuscarPorId(id);

            if (clienteBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "cliente não encontrado!",
                        erro = true
                    });
            }

            try
            {
                _ClienteRepository.Atualizar(id, clienteAtualizado);

                return NoContent();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


        [HttpDelete("excluir/{id}")]
        public IActionResult Delete(int id)
        {
            _ClienteRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
