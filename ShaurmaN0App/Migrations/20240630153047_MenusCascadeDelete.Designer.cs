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
    [Migration("20240630153047_MenusCascadeDelete")]
    partial class MenusCascadeDelete
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
                        .HasDefaultValue(new Guid("f46b24a3-0473-4247-a0a4-402246ae32bf"));

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
                            Id = new Guid("ec1abfe7-9344-4b03-8315-2800ce03d2d4"),
                            MenusCategoryId = new Guid("095b8f94-afe1-428b-9852-6596de3b8d5a"),
                            Name = "Shaurma",
                            Price = 5.0
                        },
                        new
                        {
                            Id = new Guid("480758ac-fcc4-4f29-9f7b-ec53e20778af"),
                            MenusCategoryId = new Guid("a1073a67-956a-423e-8fd5-4afb6c5c9795"),
                            Name = "Cola",
                            Price = 1.5
                        });
                });

            modelBuilder.Entity("ShaurmaN0App.Models.MenusCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValue(new Guid("ad23a096-fa50-4160-b4fb-834433293008"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenusCategory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("095b8f94-afe1-428b-9852-6596de3b8d5a"),
                            Name = "food"
                        },
                        new
                        {
                            Id = new Guid("a1073a67-956a-423e-8fd5-4afb6c5c9795"),
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