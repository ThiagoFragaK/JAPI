using JAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Entry> Entries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entry>()
                .HasData(
                    new Entry { EntryId = 1, EntryTitle = "Morte de Xim", EntryDescr = "Presidente da China morre abrindo caminho para democratização", EntryDate = new DateTime(1996, 1, 17) },
                    new Entry { EntryId = 2, EntryTitle = "Tempestade a Vista", EntryDescr = "Uma tempestada se aproxima do litoral", EntryDate = new DateTime(1998, 1, 17) });
        }
    }
}
