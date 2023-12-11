﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WordMaster.Database;

#nullable disable

namespace WordMaster.Database.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231209120134_DataSeed")]
    partial class DataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WordMaster.Database.Entities.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EnglishWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolishWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Words");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnglishWord = "Dog",
                            PolishWord = "Pies"
                        },
                        new
                        {
                            Id = 2,
                            EnglishWord = "Cat",
                            PolishWord = "Kot"
                        },
                        new
                        {
                            Id = 3,
                            EnglishWord = "Car",
                            PolishWord = "Samochód"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}