namespace QuoteLevelling.Model
{
    public class Fornecedor
    {
        public int id_fornecedor { get; set; }

        public String nome_fornecedor { get; set; }

        public String descricao_fornecedor { get; set; }

        public String tipo_fornecedor { get; set; }
        public String cnpj_fornecedor { get; set; }
        public double avaliacao_fornecedor { get; set; }
        public List<Endereco> enderecos { get; set; }

    }
}
