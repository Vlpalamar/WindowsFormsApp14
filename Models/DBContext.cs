using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp14.Models
{
    public class DBContext : DbContext
    {

        public DbSet<Disc> discs { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Band> bands { get; set; }
        public DbSet<Publisher> publishers { get; set; }

        


        public DBContext()
        {
            Database.EnsureCreated();
        }

        protected override void  OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disc>()
                .HasOne<Band>(d => d.band)
                .WithMany(b => b.discs);

            modelBuilder.Entity<Disc>()
                .HasOne<Publisher>(d => d.publisher)
                .WithMany(p => p.discs);

            modelBuilder.Entity<Disc>()
               .HasOne<Genre>(d => d.genre)
               .WithMany(p => p.discs);






        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\visual studio\WindowsFormsApp14\Database1.mdf;Integrated Security=True");
        }


    }

    
}
