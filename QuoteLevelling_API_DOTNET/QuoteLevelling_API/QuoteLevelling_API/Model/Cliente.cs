using System.Data;
using System.Numerics;
using System.Runtime.InteropServices;

namespace QuoteLevelling.Model
{
    public class Cliente
    {
        public int id_cliente { get; set; }

        public String nome_cliente { get; set; }

        public String descricao_cliente { get; set; }

        public String tipo_cliente { get; set; }

        public String cnpj_cliente { get; set; }

        public List<Endereco> enderecos { get; set; }

    }
}
