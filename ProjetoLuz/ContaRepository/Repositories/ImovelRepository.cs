using System.Collections.Generic;
using System.Linq;
using ContaDomain.Entities;
using ContaRepository.Data;
using ContaRepository.Interfaces;

namespace ContaRepository.Repository
{
    public class ImovelRepository : IImovelRepository
    {
        private DataContext context;
        public ImovelRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Imovel imovel)
        {
            context.Imoveis.Add(imovel);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Imoveis.Remove(GetById(id));   
            context.SaveChanges();
        }

        public List<Imovel> Getall()
        {
            return context.Imoveis.ToList();
        }
        public Imovel GetById(int id)
        {
            return context.Imoveis.SingleOrDefault(x=>x.id ==id);
        }

        public void Update(Imovel imovel)
        {
            var objImovel = GetById(imovel.id);
            objImovel.id = imovel.id;
            objImovel.Identificacao = imovel.Identificacao;
            objImovel.Numero = imovel.Numero;
            objImovel.Bairro = imovel.Bairro;
            objImovel.Cidade = imovel.Cidade;
            objImovel.Estado = imovel.Estado;
            context.SaveChanges();
        }
    }
}