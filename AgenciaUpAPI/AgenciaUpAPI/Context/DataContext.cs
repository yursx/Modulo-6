using AgenciaUpAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaUpAPI.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Passagens> Passagens { get; set; }
        public DbSet<Cadastro> Cadastro { get; set;}

    }
}
