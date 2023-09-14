using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_UnitOfWork
{
    public class LibraryContext:DbContext
    {
        public DbSet<Reader> Readers { get; set; }
        public DbSet<ReaderCard> ReaderCards { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=EpamLibraryDb; Username=postgres; Password=postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReaderCard>()
                .HasOne(card => card.Reader)
                .WithOne(reader => reader.Card)
                .HasForeignKey<Reader>(reader => reader.ReaderCardId);
        }
    }
}
