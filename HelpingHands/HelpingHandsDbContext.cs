using HelpingHands.Entities;
﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace HelpingHands
{
    public class HelpingHandsDbContext : DbContext
    {
        public HelpingHandsDbContext(DbContextOptions<HelpingHandsDbContext> options)  : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Ong> Ongs { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Need> Needs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Ong>()
               .HasOne(e => e.User)
               .WithOne(e => e.Ong)
               .HasForeignKey<Ong>(e => e.Id)
               .IsRequired(false);

            
            /*

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Bob",
                Email = "bob@bob.com",
                Password = "password"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                Name = "Sarah",
                Email = "sarah@sarah.com",
                Password = "password"
            });
            
            */

        }
    }
}

