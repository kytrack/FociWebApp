﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(FociDbContext))]
    [Migration("20240916112002_sqlite.local_migration_398")]
    partial class sqlitelocal_migration_398
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("WebApplication1.Models.Meccs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fordulo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HazaiCsapat")
                        .HasColumnType("TEXT");

                    b.Property<int>("HazaiFelido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HazaiVeg")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VendegCsapat")
                        .HasColumnType("TEXT");

                    b.Property<int>("VendegFelido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VendegVeg")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Meccsek");
                });
#pragma warning restore 612, 618
        }
    }
}
