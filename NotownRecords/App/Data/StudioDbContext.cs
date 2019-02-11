using System;
using System.Collections.Generic;
using System.Text;
using App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class StudioContext : DbContext
    {
        public StudioContext(DbContextOptions<StudioContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Album>().ToTable("Album");
            modelBuilder.Entity<Musician>().ToTable("Musician");
            modelBuilder.Entity<Performance>().ToTable("Performance");
            modelBuilder.Entity<Producer>().ToTable("Producer");
            modelBuilder.Entity<Song>().ToTable("Song");
        }
    }
}
