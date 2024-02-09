﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBlog.WebUI.DataAccess.Concrate.EfCore;

#nullable disable

namespace MyBlog.WebUI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240208085249_UpdateAboutAddSkills2")]
    partial class UpdateAboutAddSkills2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyBlog.WebUI.Entity.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteBook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteMovie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteMusic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("MyBlog.WebUI.Entity.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkillValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("MyBlog.WebUI.Entity.Skill", b =>
                {
                    b.HasOne("MyBlog.WebUI.Entity.About", null)
                        .WithMany("Skills")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("MyBlog.WebUI.Entity.About", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
