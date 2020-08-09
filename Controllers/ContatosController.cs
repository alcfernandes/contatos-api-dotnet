using System.Collections.Generic;
using Contatos.Data;
using Contatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contatos.Controllers
{
    [Route("api/contatos")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly MockContatosRepo _repository = new MockContatosRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Contato>> GetAllContatos()
        {
            var contatos = _repository.GetContatos();
            return Ok(contatos);
        }

        [HttpGet("{id}")]
        public ActionResult<Contato> GetContatoById(int id)
        {
            var contato = _repository.GetContatoById(id);
            return Ok(contato);
        }

    }
}