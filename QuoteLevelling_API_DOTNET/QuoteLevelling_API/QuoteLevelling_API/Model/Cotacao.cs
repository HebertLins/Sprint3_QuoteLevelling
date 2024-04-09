namespace QuoteLevelling.Model
{
    public class Cotacao
    {
        public int id_cotacao { get; set; }
        public double valTotal_cotacao { get; set; }
        public int qtdTotal_cotacao { get; set; }
        
        public List<Material> materiais{ get; set; }
        public List<Cliente> clientes { get; set; }
        public List<Fornecedor> fornecedores { get; set; }

    }
}
