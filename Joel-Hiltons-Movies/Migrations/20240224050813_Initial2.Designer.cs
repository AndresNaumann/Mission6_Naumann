﻿// <auto-generated />
using System;
using Joel_Hiltons_Movies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Joel_Hiltons_Movies.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240224050813_Initial2")]
    partial class Initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Joel_Hiltons_Movies.Models.Application", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CopiedToPlex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lent_to")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Joel_Hiltons_Movies.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Joel_Hiltons_Movies.Models.Application", b =>
                {
                    b.HasOne("Joel_Hiltons_Movies.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}