using Microsoft.EntityFrameworkCore;
using Biblioteca.Entities.Models;

namespace Biblioteca.DAL
{
    public class BibliotecaDBContext : DbContext
    {
        public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options): base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
