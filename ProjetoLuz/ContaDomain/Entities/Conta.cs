using System;

namespace ContaDomain.Entities
{
    public class Conta
    {
         public Conta()
        {
            
        }

        public Conta(int id, DateTime dataLeitura, double numeroLeitura, double qtdKw, double valorConta, DateTime dataPagamento, double mediaConsumo, Imovel imovel) 
        {
            this.id = id;
            this.dataLeitura = dataLeitura;
            this.numeroLeitura = numeroLeitura;
            this.qtdKw = qtdKw;
            this.valorConta = valorConta;
            this.dataPagamento = dataPagamento;
            this.mediaConsumo = mediaConsumo;
            this.imovel = imovel;
        }
    	public int id { get; set; }

        public DateTime dataLeitura { get; set; }

        public double numeroLeitura { get; set; }

        public double qtdKw { get; set; }

        public double valorConta { get; set; }

        public DateTime dataPagamento { get; set; }

        public double mediaConsumo { get; set; }
        public Imovel imovel { get; set; }
    }
}