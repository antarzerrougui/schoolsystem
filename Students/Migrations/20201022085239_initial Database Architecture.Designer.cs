﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Students.Data;

namespace Students.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201022085239_initial Database Architecture")]
    partial class initialDatabaseArchitecture
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Students.Models.Classe", b =>
                {
                    b.Property<int>("ClassseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaasseLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClasseNumber")
                        .HasColumnType("int");

                    b.HasKey("ClassseId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Students.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Absence")
                        .HasColumnType("int");

                    b.Property<int?>("ClasseClassseId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClasseClassseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Students.Models.Student", b =>
                {
                    b.HasOne("Students.Models.Classe", null)
                        .WithMany("ClasseStudents")
                        .HasForeignKey("ClasseClassseId");
                });
#pragma warning restore 612, 618
        }
    }
}
