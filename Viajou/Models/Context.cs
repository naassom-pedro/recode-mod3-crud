using Microsoft.EntityFrameworkCore;

namespace Viajou.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NP-Laptop;Initial Catalog=viajou_db;User ID=sa; Password=ac11666dc@");
        }
        public DbSet<Cliente>Cliente { get; set; }  
        public DbSet<Destino>Destino { get; set; }  
        public DbSet<Venda>Venda { get; set; }  
        public DbSet<Contato>Contato { get; set; }  
    }
}
