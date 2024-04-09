using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("responsavel")]
    public class ResponsavelController : Controller
    {
        private static List<Responsavel> _responsaveis = new List<Responsavel>
        {
            new Responsavel
            {
                id_responsavel = 1,
                nome_responsavel = "Responsavel A",
                descricao_responsavel = "Descrição do Responsavel A",
                matricula_responsavel = "123456",
                clientes = new List<Cliente>
                {
                    new Cliente { id_cliente = 1, nome_cliente = "Cliente X" },
                    new Cliente { id_cliente = 2, nome_cliente = "Cliente Y" }
                },
                fornecedores = new List<Fornecedor>
                {
                    new Fornecedor { id_fornecedor = 1, nome_fornecedor = "Fornecedor X" },
                    new Fornecedor { id_fornecedor = 2, nome_fornecedor = "Fornecedor Y" }
                }
             }
        };
    

        [HttpGet]
            public IActionResult Get()
            {
                return Ok(_responsaveis);
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var responsavel = _responsaveis.Find(r => r.id_responsavel == id);
                if (responsavel == null)
                {
                    return NotFound();
                }
                return Ok(responsavel);
            }
    }
}

