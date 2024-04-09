using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("cotacao")]
    public class CotacaoController : Controller
    {

        private static List<Cotacao> _cotacoes = new List<Cotacao>
    {
        new Cotacao
        {
            id_cotacao = 1,
            valTotal_cotacao = 1000,
            qtdTotal_cotacao = 10,
            materiais = new List<Material>
            {
                new Material { id_material = 1, nome_material = "Material A", qtd_material = 100, ValUnit_material = 50.00, descricao_material = "Descrição do Material A",
                fornecedores = new List<Fornecedor>
                {
                    new Fornecedor { id_fornecedor = 1, nome_fornecedor = "Fornecedor X" },
                    new Fornecedor { id_fornecedor = 2, nome_fornecedor = "Fornecedor Y" }
                }},
                new Material { id_material = 2, nome_material = "Material B", qtd_material = 200, ValUnit_material = 10.00, descricao_material = "Descrição do Material B",
                fornecedores = new List<Fornecedor>
                {
                    new Fornecedor { id_fornecedor = 1, nome_fornecedor = "Fornecedor X" },
                    new Fornecedor { id_fornecedor = 2, nome_fornecedor = "Fornecedor Y" }
                }}
            },

            clientes = new List<Cliente>
            {
                new Cliente
            {
                id_cliente = 1, nome_cliente = "Cliente A", descricao_cliente = "Descrição do Cliente A", tipo_cliente = "Tipo A", cnpj_cliente = "12345678901234",
                enderecos = new List<Endereco>
                {
                    new Endereco { id_endereco = 1, rua_endereco = "Rua A", cidade_endereco = "Cidade A", uf_endereco = "Estado A", cep_endereco = "00000-000", numero_endereco = "123" }
                }
            }
            
            },
            fornecedores = new List<Fornecedor>
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
                       new Endereco { id_endereco = 2, rua_endereco = "Rua B", cidade_endereco = "Cidade B", uf_endereco = "Estado B", cep_endereco = "11111-111", numero_endereco = "456" }
                    }
                }
            }
        }
    };

        [HttpGet("{id}")]
        public IActionResult getCotacoes(int id)
        {
            var cotacao = _cotacoes.Find(c => c.id_cotacao == id);
            if (cotacao == null)
            {
                return NotFound();
            }
            return Ok(cotacao);
        }

    }
}
