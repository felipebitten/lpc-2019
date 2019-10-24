using System;
using System.Collections.Generic;
using System.Linq;
using ContaDomain.Entities;
using ContaRepository.Data;
using ContaRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ContaRepository.Repository
{
    public class ContasRepository : IContaRepository
    {
 
        private DataContext context;
        public ContasRepository(DataContext context)
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
            context.contas.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Conta> Getall()
        {
           return context.contas.Include(x=>x.imovel).ToList();
        }

        public Conta GetById(int id)
        {
            return context.contas.Include(x=>x.imovel).SingleOrDefault(x=>x.id==id);
        }

        public void Update(Conta conta)
        {
            var objConta = GetById(conta.id);
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
           var maiorConsumo = Getall();
            if(maiorConsumo.Any()) 
            {
                return maiorConsumo.OrderBy(x => x.qtdKw).Last();
            }
            return null;
        }

        public Conta Menor(){
             var menorConsumo = Getall();
            if(menorConsumo.Any())
            {
                return menorConsumo.OrderBy(x => x.qtdKw).First();
            }
            return null;
        }
    }
}