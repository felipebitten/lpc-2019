using Microsoft.EntityFrameworkCore;


namespace Conta.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) 
            {
                
            }

            public DbSet<Conta> contas { get; set; }
    }
}