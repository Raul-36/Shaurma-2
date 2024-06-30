﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShaurmaN0App.Data;

#nullable disable

namespace ShaurmaN0App.Migrations
{
    [DbContext(typeof(ShaurmaDbContext))]
    [Migration("20240628121540_RemoveLog")]
    partial class RemoveLog
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShaurmaN0App.Models.Menus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("be4155fc-306d-44ae-8c3a-1cfb9ba9ca38"));

                    b.Property<Guid?>("MenusCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MenusCategoryId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae14d479-5ce8-4ec1-ae4c-d233dacab0c4"),
                            MenusCategoryId = new Guid("d9f1bf75-5296-4a41-8357-d1121136a3f5"),
                            Name = "Shaurma",
                            Price = 5.0
                        },
                        new
                        {
                            Id = new Guid("2f643f32-2aa7-47e6-ac1e-ea97ab2f03c8"),
                            MenusCategoryId = new Guid("03601bd2-66af-4290-9506-efee2374bba1"),
                            Name = "Cola",
                            Price = 1.5
                        });
                });

            modelBuilder.Entity("ShaurmaN0App.Models.MenusCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("43c639e4-4163-4503-b806-a719b386f8ad"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenusCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d9f1bf75-5296-4a41-8357-d1121136a3f5"),
                            Name = "food"
                        },
                        new
                        {
                            Id = new Guid("03601bd2-66af-4290-9506-efee2374bba1"),
                            Name = "drinkables"
                        });
                });

            modelBuilder.Entity("ShaurmaN0App.Models.Menus", b =>
                {
                    b.HasOne("ShaurmaN0App.Models.MenusCategory", "MenusCategory")
                        .WithMany("Menus")
                        .HasForeignKey("MenusCategoryId");

                    b.Navigation("MenusCategory");
                });

            modelBuilder.Entity("ShaurmaN0App.Models.MenusCategory", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}