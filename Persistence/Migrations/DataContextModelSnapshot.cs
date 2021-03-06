﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("Domain.Investment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Asset")
                        .HasColumnType("TEXT");

                    b.Property<string>("AssetClass")
                        .HasColumnType("TEXT");

                    b.Property<string>("Broker")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CapitalGainTax")
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("EmolumentsCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LiquidationCosts")
                        .HasColumnType("TEXT");

                    b.Property<string>("Market")
                        .HasColumnType("TEXT");

                    b.Property<string>("OperationType")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("RegistryCost")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Investments");
                });
#pragma warning restore 612, 618
        }
    }
}
