using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWebAppCoreMVC.Models
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        //Data Seeding

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId="work", Name="Work"},
                 new Category { CategoryId= "ex", Name="Exercise"},
                 new Category { CategoryId="shop", Name="Shopping"},
                 new Category { CategoryId="home", Name="Home"},
                 new Category {CategoryId="call", Name="Contacts"},
                 new Category {CategoryId="mail", Name="Email" }
                );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId="open", Name="Open"},
                new Status { StatusId="closed", Name="Completed"}
                );
        }

         
    }
}
