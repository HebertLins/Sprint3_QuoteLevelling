using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("endereco")]
    public class EnderecoController : Controller
    {
        private static List<Endereco> _enderecos = new List<Endereco>
        {
        new Endereco { id_endereco = 1,
            rua_endereco = "Rua A",
            cidade_endereco = "Cidade A",
            uf_endereco = "UF A",
            cep_endereco = "00000-000",
            numero_endereco = "123" },
        
        new Endereco { id_endereco = 2, 
            rua_endereco = "Rua B", 
            cidade_endereco = "Cidade B", 
            uf_endereco = "UF B", 
            cep_endereco = "11111-111", 
            numero_endereco = "456" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_enderecos);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var endereco = _enderecos.Find(e => e.id_endereco == id);
            if (endereco == null)
            {
                return NotFound();
            }
            return Ok(endereco);
        }
    }
}
