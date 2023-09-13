using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Reader> Readers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=EpamLibraryDb; Username=postgres; Password=postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .HasOne(card => card.Reader)
                .WithOne(reader => reader.Card)
                .HasForeignKey<Reader>(reader => reader.CardId);
        }

    }
}
