using Microsoft.EntityFrameworkCore;

namespace LojaMVC.Data
{
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {
        }
        public DbSet<Models.Cliente> Clientes { get; set; }
        public DbSet<Models.Produto> Produtos { get; set; }
    }
}
