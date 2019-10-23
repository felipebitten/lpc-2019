using System;
using System.Collections.Generic;
using System.Linq;
using ContaDomain.Entities;
using ContaRepository.Data;
using ContaRepository.Interfaces;

namespace ContaRepository.Repository
{
    public class ContaRepository : IContaRepository
    {

        private DataContext context;

        public ContaRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Conta conta)
        {
            context.contas.Add(conta);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.contas.Remove(GetByID(id));
            context.SaveChanges();
        }

        public List<Conta> GetAll()
        {
           return context.contas.ToList();
        }

        public Conta GetByID(int id)
        {
            return context.contas.SingleOrDefault(x=>x.id == id);
        }

        public void Update(Conta conta)
        {
            var objConta = GetByID(conta.id);
            objConta.id = conta.id;
            objConta.dataLeitura = conta.dataLeitura;
            objConta.numeroLeitura = conta.numeroLeitura;
            objConta.qtdKw = conta.qtdKw;
            objConta.valorConta = conta.valorConta;
            objConta.dataPagamento = conta.dataPagamento;
            objConta.mediaConsumo = conta.mediaConsumo;
            context.SaveChanges();
        }

        public Conta Maior(){
            List<Conta> contas = GetAll();
            DateTime padrao = new DateTime(2019,01,01);
            if (contas.Count==0){
                Conta vazio = new Conta(0,padrao,0,0,0.0,padrao,0);
                return vazio;
            }
            var Maximo = contas.Max(x=>x.qtdKw);
            return contas.Where(x=>x.qtdKw==Maximo).FirstOrDefault();
        }

        public Conta Menor(){
            List<Conta> contas = GetAll();
            DateTime padrao = new DateTime(2019,01,01);
            if (contas.Count==0){
                Conta vazio = new Conta(0,padrao,0,0,0.0,padrao,0);
                return vazio;
            }
            var Minimo = contas.Min(x=>x.qtdKw);
            return contas.Where(x=>x.qtdKw==Minimo).FirstOrDefault();
        }

    }
}