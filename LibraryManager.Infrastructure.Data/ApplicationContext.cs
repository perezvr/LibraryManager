using LibraryManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Livro>()
                .HasIndex(l => l.ISBN)
                .IsUnique();
        }
    }
}
