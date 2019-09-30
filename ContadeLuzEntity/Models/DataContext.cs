using Microsoft.EntityFrameworkCore;

namespace ContadeLuz.Models
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