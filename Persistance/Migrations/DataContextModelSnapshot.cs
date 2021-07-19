﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

namespace Persistance.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ORI")
                        .HasColumnType("TEXT");

                    b.Property<string>("NIC")
                        .HasColumnType("TEXT");

                    b.Property<string>("NAM")
                        .HasColumnType("TEXT");

                    b.Property<string>("SEX")
                        .HasColumnType("TEXT");

                    b.Property<string>("RAC")
                        .HasColumnType("TEXT");

                    b.Property<string>("ETN")
                        .HasColumnType("TEXT");

                    b.Property<string>("POB")
                        .HasColumnType("TEXT");

                    b.Property<string>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("ORD")
                        .HasColumnType("TEXT");

                    b.Property<string>("ERD")
                        .HasColumnType("TEXT");

                    b.Property<string>("SXP")
                        .HasColumnType("TEXT");

                    b.Property<string>("HGT")
                        .HasColumnType("TEXT");

                    b.Property<string>("WGT")
                        .HasColumnType("TEXT");

                    b.Property<string>("EYE")
                        .HasColumnType("TEXT");

                    b.Property<string>("HAI")
                        .HasColumnType("TEXT");

                    b.Property<string>("FBI")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Offenders");
                });
#pragma warning restore 612, 618
        }
    }
}
