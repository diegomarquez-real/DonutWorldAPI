﻿// <auto-generated />
using DonutWorldAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DonutWorldAPI.Migrations
{
    [DbContext(typeof(DonutWorldContext))]
    partial class DonutWorldContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DonutWorldAPI.Models.Donut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasMaxLength(5);

                    b.Property<double>("ProductionCost")
                        .HasColumnType("float")
                        .HasMaxLength(5);

                    b.Property<double>("Profit")
                        .HasColumnType("float")
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.ToTable("Donuts");
                });
#pragma warning restore 612, 618
        }
    }
}
