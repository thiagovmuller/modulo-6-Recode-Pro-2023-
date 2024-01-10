using Microsoft.EntityFrameworkCore;
using modulo6api.Models;

namespace modulo6api.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Passagem> Passagem { get; set; }
        public DbSet<Compra> Compra { get; set; }

    }
}
