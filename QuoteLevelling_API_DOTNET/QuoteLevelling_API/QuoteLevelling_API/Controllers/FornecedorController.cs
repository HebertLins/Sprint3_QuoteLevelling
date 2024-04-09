using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("fornecedor")]
    public class FornecedorController : Controller
    {
        private static List<Fornecedor> _fornecedores = new List<Fornecedor>
    {
        new Fornecedor
        {
            id_fornecedor = 1,
            nome_fornecedor = "Fornecedor A",
            descricao_fornecedor = "Descrição do Fornecedor A",
            tipo_fornecedor = "Tipo A",
            cnpj_fornecedor = "12345678901234",
            avaliacao_fornecedor = 4.5,
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
            return Ok(_fornecedores);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var fornecedor = _fornecedores.Find(f => f.id_fornecedor == id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }
    }

}
