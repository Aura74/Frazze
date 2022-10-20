﻿// <auto-generated />
using System;
using Frazze_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Frazze_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221020112254_dropdown4")]
    partial class dropdown4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Frazze_DataAccess.Applications", b =>
                {
                    b.Property<int>("ApplicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationID"), 1L, 1);

                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created")
                        .HasColumnType("datetime2");

                    b.HasKey("ApplicationID");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("Frazze_DataAccess.Phrases", b =>
                {
                    b.Property<int>("PhraseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhraseID"), 1L, 1);

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationID")
                        .HasColumnType("int");

                    b.Property<string>("Culture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Element")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrginalPhrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhraseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhraseID");

                    b.HasIndex("ApplicationID");

                    b.ToTable("Phrases");
                });

            modelBuilder.Entity("Frazze_DataAccess.Phrases", b =>
                {
                    b.HasOne("Frazze_DataAccess.Applications", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });
#pragma warning restore 612, 618
        }
    }
}
