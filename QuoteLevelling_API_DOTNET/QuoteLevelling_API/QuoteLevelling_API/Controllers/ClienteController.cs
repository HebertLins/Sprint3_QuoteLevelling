using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : Controller
    {
        private static List<Cliente> _clientes = new List<Cliente>{
            new Cliente
            {
                id_cliente = 1,
                nome_cliente = "Cliente A",
                descricao_cliente = "Descrição do Cliente A",
                tipo_cliente = "Tipo A",
                cnpj_cliente = "12345678901234",
                enderecos = new List<Endereco>
                {
                    new Endereco { id_endereco = 1, rua_endereco = "Rua A", cidade_endereco = "Cidade A", uf_endereco = "Estado A", cep_endereco = "00000-000", numero_endereco = "123" },
                    new Endereco { id_endereco = 2, rua_endereco = "Rua B", cidade_endereco = "Cidade B", uf_endereco = "Estado B", cep_endereco = "11111-111", numero_endereco = "456" }
                }
            }
           };


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = _clientes.Find(c => c.id_cliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
    }
}
    

