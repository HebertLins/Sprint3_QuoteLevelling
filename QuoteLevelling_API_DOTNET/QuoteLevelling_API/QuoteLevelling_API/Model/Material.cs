namespace QuoteLevelling.Model
{
    public class Material
    {
        public int id_material { get; set; }
        public string nome_material { get; set; }
        public int qtd_material { get; set; }
        public double ValUnit_material { get; set; }
        public string descricao_material { get; set; }
        public List<Fornecedor> fornecedores { get; set; }
    }
}
