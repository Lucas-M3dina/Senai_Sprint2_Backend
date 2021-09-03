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
    [Route("api/[controller]")]
    [ApiController]
    public class AluguelController : ControllerBase
    {
        private IAluguelRepository _AluguelRepository { get; set; }

        public AluguelController()
        {
            _AluguelRepository = new AluguelRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<AluguelDomain> listaAluguel = _AluguelRepository.ListarTodos();

            return Ok(listaAluguel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            AluguelDomain aluguelBuscado = _AluguelRepository.BuscarPorId(id);

            if (aluguelBuscado == null)
            {
                return NotFound("Nenhum aluguel encontrado!");
            }

            return Ok(aluguelBuscado);
        }

        [HttpPost]
        public IActionResult Post(AluguelDomain novoAluguel)
        {
            _AluguelRepository.Inserir(novoAluguel);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult PutUrl(int id, AluguelDomain aluguelAtualizado)
        {
            AluguelDomain aluguelBuscado = _AluguelRepository.BuscarPorId(id);

            if (aluguelBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Aluguel não encontrado!",
                        erro = true
                    });
            }

            try
            {
                _AluguelRepository.Atualizar(id, aluguelAtualizado);

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
            _AluguelRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}

