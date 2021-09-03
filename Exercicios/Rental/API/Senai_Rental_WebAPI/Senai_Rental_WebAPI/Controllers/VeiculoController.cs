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
    public class VeiculoController : ControllerBase
    {
        private IVeiculoRepository _VeiculoRepository { get; set; }

        public VeiculoController()
        {
            _VeiculoRepository = new VeiculoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<VeiculoDomain> listaVeiculo = _VeiculoRepository.ListarTodos();

            return Ok(listaVeiculo);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            VeiculoDomain veiculoBuscado = _VeiculoRepository.BuscarPorId(id);

            if (veiculoBuscado == null)
            {
                return NotFound("Nenhum veiculo encontrado!");
            }

            return Ok(veiculoBuscado);
        }

        [HttpPost]
        public IActionResult Post(VeiculoDomain novoVeiculo)
        {
            _VeiculoRepository.Inserir(novoVeiculo);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult PutUrl(int id, VeiculoDomain veiculoAtualizado)
        {
            VeiculoDomain veiculoBuscado = _VeiculoRepository.BuscarPorId(id);

            if (veiculoBuscado == null)
            {
                return NotFound
                    (new
                    {
                        mensagem = "Veiculo não encontrado!",
                        erro = true
                    });
            }

            try
            {
                _VeiculoRepository.Atualizar(id, veiculoAtualizado);

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
            _VeiculoRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
