﻿// <auto-generated />
using System;
using AbsenzAPPDBHosting.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AbsenzAPPDBHosting.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241205231637_DbRelation")]
    partial class DbRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Absenzen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Absenzgrund")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Lehrer")
                        .HasColumnType("int");

                    b.Property<int>("Modul")
                        .HasColumnType("int");

                    b.Property<string>("Notiz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchuelerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchuelerId");

                    b.ToTable("Absenzen");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Absenzgruende", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Grund")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Absenzgruende");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Eltern", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Handynummer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eltern");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Klassen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Klasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Klassen");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Lehrer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lehrer");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Modul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Schueler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Eltern")
                        .HasColumnType("int");

                    b.Property<int>("Klasse")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schueler");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Absenzen", b =>
                {
                    b.HasOne("AbsenzAPPDBHosting.Models.Schueler", "Schueler")
                        .WithMany("Absenzen")
                        .HasForeignKey("SchuelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schueler");
                });

            modelBuilder.Entity("AbsenzAPPDBHosting.Models.Schueler", b =>
                {
                    b.Navigation("Absenzen");
                });
#pragma warning restore 612, 618
        }
    }
}
