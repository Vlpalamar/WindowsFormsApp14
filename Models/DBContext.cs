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

        public DbSet<RelationShip.DiscGeners> DiscGeners { get; set; }


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


            modelBuilder.Entity<RelationShip.DiscGeners>().HasKey(DG => new { DG.discId, DG.genreId });

            modelBuilder.Entity<RelationShip.DiscGeners>()
                .HasOne<Disc>(dg => dg.disc)
                .WithMany(d => d.discsGeners)
                .HasForeignKey(dg => dg.discId);

            modelBuilder.Entity<RelationShip.DiscGeners>()
               .HasOne<Genre>(dg => dg.genre)
               .WithMany(g=> g.discsGeners)
               .HasForeignKey(dg => dg.genreId);






        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\visual studio\WindowsFormsApp14\Database1.mdf;Integrated Security=True");
        }


    }

    
}
