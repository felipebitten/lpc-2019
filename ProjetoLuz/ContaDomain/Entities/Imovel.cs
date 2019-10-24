using System.Collections.Generic;

namespace ContaDomain.Entities
{
    public class Imovel
    {
        public Imovel()
        {}
        public Imovel(int id, string identificacao, string numero, string bairro, string cidade, string estado, List<Conta> contasLuz)
        {
            this.id = id;
            Identificacao = identificacao;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            this.contas = contas;
        }

        public int id { get; set; }
        public string Identificacao { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public List<Conta> contas { get; set; }
    }
}