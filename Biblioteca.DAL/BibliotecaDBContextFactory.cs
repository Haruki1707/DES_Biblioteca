using Biblioteca.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Biblioteca
{
    public class BibliotecaDBContextFactory : IDesignTimeDbContextFactory<BibliotecaDBContext>
    {
        public BibliotecaDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BibliotecaDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Biblioteca;Trusted_Connection=True");

            return new BibliotecaDBContext(optionsBuilder.Options);
        }
    }
}
