namespace QuoteLevelling.Model
{
    public class Responsavel
    {
        public int id_responsavel { get; set; }
        public string nome_responsavel { get; set; }
        public string descricao_responsavel { get; set; }
        public string matricula_responsavel { get; set; }
        public List<Cliente> clientes { get; set; }
        public List<Fornecedor> fornecedores { get; set; }

    }
}
