using Microsoft.AspNetCore.Mvc;
using QuoteLevelling.Model;

namespace QuoteLevelling.Controllers
{
    [ApiController]
    [Route("material")]
    public class MaterialController : Controller
    {
        private static List<Material> _materiais = new List<Material>
            {
            new Material
            {
                id_material = 1,
                nome_material = "Material A",
                qtd_material = 100,
                ValUnit_material = 50.00,
                descricao_material = "Descrição do Material A",
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
            return Ok(_materiais);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var material = _materiais.Find(m => m.id_material == id);
            if (material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }
    }
}
