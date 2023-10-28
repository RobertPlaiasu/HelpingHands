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

            
            

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Bob",
                Email = "bob@bob.com",
                
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                Name = "Sarah",
                Email = "sarah@sarah.com",
                OngId = 1
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Ajutor oameni fara adapost"

            });
            modelBuilder.Entity<Ong>().HasData(new Ong
            {
                Id = 1,
                Name = "Asociatia Aluziva",
                Address = "Str. Dimitrie Cantemir nr. 3",
                ONGDescription = "Suntem toți aici să învățăm și împreună să facem o schimbare. Susținem comunitățile defavorizate, în mod special mamele și copiii din medii vulnerabile, educația în mediul rural și orice alte cauze care nu pot schimba lumea, dar pot schimba lumea cuiva. Picătură cu picătură se face un ocean. #picaturacupicaturasefaceunocean",
                Number = "3213132213",
                Ocupation = "Oameni fara adapost",
                UserId = 1,
                Image = " ../../assets/aluziva.png",
                Email = "hello@asociatiaaluziva.ro",
                CategoryId =1,
                x= 44393315591258590,
                y= 26043945138016127,
            });
            modelBuilder.Entity<Post>().HasData(new Post
            {
                Id = 1,
                Title = "Ajuta oamenii fara adapost",
                
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent condimentum lacinia convallis. Donec in tortor nec odio elementum aliquam facilisis a lorem. Aliquam placerat convallis orci, quis ullamcorper lorem consectetur et. Mauris in turpis et leo pretium tempor. Nullam vel posuere lacus. Aenean ut diam non ligula sagittis sagittis. Quisque ac dictum urna, non eleifend lectus.",
                CategoryId = 1,
                OngId = 1,
                Image = "./default.png",
                Address = "Str. Dimitrie Cantemir nr. 3",
                County = "Bucuresti"
            });
            modelBuilder.Entity<Need>().HasData(new Need
            {
                Id = 1,
                Name = "lemn",
                Quantity = 50,
                PostId = 1
            });
            modelBuilder.Entity<Need>().HasData(new Need
            {
                Id = 2,
                Name = "bax caramida",
                Quantity = 500,
                PostId = 1
            });




        }
    }
}

