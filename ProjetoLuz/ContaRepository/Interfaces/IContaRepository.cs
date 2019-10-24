using System.Collections.Generic;
using ContaDomain.Entities;

namespace ContaRepository.Interfaces
{
    public interface IContaRepository : IBaseRepository<Conta>
    {
        Conta Maior();
        Conta Menor();
    }
}