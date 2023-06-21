﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoWebAppCoreMVC.Models;

namespace TodoWebAppCoreMVC.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    [Migration("20230619094032_second-migration")]
    partial class secondmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoWebAppCoreMVC.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "work",
                            Name = "Work"
                        },
                        new
                        {
                            CategoryID = "ex",
                            Name = "Exercise"
                        },
                        new
                        {
                            CategoryID = "shop",
                            Name = "Shopping"
                        },
                        new
                        {
                            CategoryID = "home",
                            Name = "Home"
                        },
                        new
                        {
                            CategoryID = "call",
                            Name = "Contacts"
                        },
                        new
                        {
                            CategoryID = "mail",
                            Name = "Email"
                        });
                });

            modelBuilder.Entity("TodoWebAppCoreMVC.Models.Status", b =>
                {
                    b.Property<string>("StatusID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusID = "open",
                            Name = "Open"
                        },
                        new
                        {
                            StatusID = "closed",
                            Name = "Completed"
                        });
                });

            modelBuilder.Entity("TodoWebAppCoreMVC.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StatusId");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("TodoWebAppCoreMVC.Models.ToDo", b =>
                {
                    b.HasOne("TodoWebAppCoreMVC.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoWebAppCoreMVC.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
