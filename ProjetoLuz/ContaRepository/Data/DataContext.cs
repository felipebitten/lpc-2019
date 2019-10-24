using ContaDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContaRepository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
            {

            }
        public DbSet<Conta> contas {get; set;}
        public DbSet<Imovel> Imoveis {get; set;}  
    }
}