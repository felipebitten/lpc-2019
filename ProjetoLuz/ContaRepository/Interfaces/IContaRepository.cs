using System.Collections.Generic;
using ContaDomain.Entities;

namespace ContaRepository.Interfaces
{
    public interface IContaRepository
    {
         void Create (Conta conta);
         void Update(Conta conta);
         void Delete(int id);

         Conta GetByID(int id);

        List<Conta> GetAll();

        Conta Maior();
        Conta Menor();
    }
}