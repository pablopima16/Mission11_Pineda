﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using BookStoreProject.Models;

#nullable disable

namespace BookStoreProject.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20240328232945_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("TheBookstoreProject.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectImpact")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ProjectInstallation")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
