
using Microsoft.EntityFrameworkCore;
using SGREFRI.ApplicationCore.Entities;

namespace SGREFRI.Infrastructure.Data
{
   public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext>options) : base(options)
        {
               
        }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }
    }
}
