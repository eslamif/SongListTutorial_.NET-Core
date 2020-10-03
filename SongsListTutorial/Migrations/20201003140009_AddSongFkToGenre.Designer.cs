﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongsListTutorial.Models;

namespace SongsListTutorial.Migrations
{
    [DbContext(typeof(SongContext))]
    [Migration("20201003140009_AddSongFkToGenre")]
    partial class AddSongFkToGenre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SongsListTutorial.Models.Genre", b =>
                {
                    b.Property<string>("GenreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            GenreID = "M",
                            Name = "Metal"
                        },
                        new
                        {
                            GenreID = "R",
                            Name = "Rap"
                        },
                        new
                        {
                            GenreID = "H",
                            Name = "Hi Hop"
                        },
                        new
                        {
                            GenreID = "RC",
                            Name = "Rock"
                        });
                });

            modelBuilder.Entity("SongsListTutorial.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SongId");

                    b.HasIndex("GenreID");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            GenreID = "M",
                            Name = "Master of Puppets",
                            Rating = 5,
                            Year = 1980
                        },
                        new
                        {
                            SongId = 2,
                            GenreID = "RC",
                            Name = "Wonderwall",
                            Rating = 4,
                            Year = 1990
                        },
                        new
                        {
                            SongId = 3,
                            GenreID = "R",
                            Name = "Lose Yourself",
                            Rating = 1,
                            Year = 2005
                        });
                });

            modelBuilder.Entity("SongsListTutorial.Models.Song", b =>
                {
                    b.HasOne("SongsListTutorial.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
