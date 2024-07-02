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
    [Migration("20240702085813_UniqueNames")]
    partial class UniqueNames
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
                        .HasDefaultValue(new Guid("97c81f96-5fe9-402d-965e-8a948702a851"));

                    b.Property<Guid?>("MenusCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MenusCategoryId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("146851d6-3158-4be1-ac7d-da077f8703cc"),
                            MenusCategoryId = new Guid("ba8560ae-88cb-4f03-b7df-a5574ccdbe56"),
                            Name = "Shaurma",
                            Price = 5.0
                        },
                        new
                        {
                            Id = new Guid("2f18e7e0-5aec-4910-9fa6-7b385e4e2c79"),
                            MenusCategoryId = new Guid("1c2edb52-859b-43dc-8195-1078a72fa35f"),
                            Name = "Cola",
                            Price = 1.5
                        });
                });

            modelBuilder.Entity("ShaurmaN0App.Models.MenusCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("3069e09f-ca72-4726-a589-0ac917b5d4cc"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MenusCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba8560ae-88cb-4f03-b7df-a5574ccdbe56"),
                            Name = "food"
                        },
                        new
                        {
                            Id = new Guid("1c2edb52-859b-43dc-8195-1078a72fa35f"),
                            Name = "drinkables"
                        });
                });

            modelBuilder.Entity("ShaurmaN0App.Models.Menus", b =>
                {
                    b.HasOne("ShaurmaN0App.Models.MenusCategory", "MenusCategory")
                        .WithMany("Menus")
                        .HasForeignKey("MenusCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

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
