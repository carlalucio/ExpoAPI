using ExoAPI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
namespace ExoAPI.Contexts
{
    public class dbExoAPIContext : DbContext
    {
        public dbExoAPIContext() { }

        public dbExoAPIContext(DbContextOptions<dbExoAPIContext> options) : base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=CL\\SQLEXPRESS; initial catalog= dbExoAPI; Integrated Security=true");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
