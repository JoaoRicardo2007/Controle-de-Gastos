using Microsoft.AspNetCore.Mvc;
using ControleDeGastos.Models;
using ControleDeGastos.Interfaces;

namespace ControleDeGastos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarteiraController : ControllerBase
    {
        private readonly ICarteiraService _carteiraService;

        public CarteiraController(ICarteiraService carteiraService)
        {
            _carteiraService = carteiraService;
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var carteiras = _carteiraService.ListarCarteiras();
            return Ok(carteiras);
        }

        [HttpPost]
        public ActionResult Criar([FromBody] Carteira novaCarteira)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _carteiraService.AdicionarCarteira(novaCarteira);
            return CreatedAtAction(nameof(Listar), new { id = novaCarteira.Id }, novaCarteira);
        }

        [HttpDelete("{id}")]
        public ActionResult Excluir(int id)
        {
            _carteiraService.RemoverCarteira(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Atualizar(int id, [FromBody] Carteira carteiraAtualizada)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _carteiraService.AtualizarCarteira(id, carteiraAtualizada);
            return NoContent();
        }
    }
}
