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
    [Migration("20221021132817_pages6")]
    partial class pages6
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

            modelBuilder.Entity("Frazze_DataAccess.Cultures", b =>
                {
                    b.Property<int>("CultureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CultureID"), 1L, 1);

                    b.Property<string>("Culture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("created")
                        .HasColumnType("datetime2");

                    b.HasKey("CultureID");

                    b.ToTable("Culture");
                });

            modelBuilder.Entity("Frazze_DataAccess.Pages", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ApplicationID")
                        .HasColumnType("int");

                    b.Property<string>("PageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationID");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("Frazze_DataAccess.Phrases", b =>
                {
                    b.Property<int>("PhraseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhraseID"), 1L, 1);

                    b.Property<int>("AppId")
                        .HasColumnType("int");

                    b.Property<int>("CultId")
                        .HasColumnType("int");

                    b.Property<string>("Element")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrginalPhrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PageId")
                        .HasColumnType("int");

                    b.Property<string>("Phrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhraseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhraseID");

                    b.HasIndex("AppId");

                    b.HasIndex("CultId");

                    b.HasIndex("PageId");

                    b.ToTable("Phrases");
                });

            modelBuilder.Entity("Frazze_DataAccess.Pages", b =>
                {
                    b.HasOne("Frazze_DataAccess.Applications", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Frazze_DataAccess.Phrases", b =>
                {
                    b.HasOne("Frazze_DataAccess.Applications", "Application")
                        .WithMany()
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Frazze_DataAccess.Cultures", "Cultures")
                        .WithMany()
                        .HasForeignKey("CultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Frazze_DataAccess.Pages", "Pages")
                        .WithMany()
                        .HasForeignKey("PageId");

                    b.Navigation("Application");

                    b.Navigation("Cultures");

                    b.Navigation("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}
