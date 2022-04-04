﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rpg2.Data;

#nullable disable

namespace vueproj.Migrations
{
    [DbContext(typeof(DataContext1))]
    partial class DataContext1ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("rpg2.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("Day")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PercentDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PercentMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PercentYear")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Summ")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
