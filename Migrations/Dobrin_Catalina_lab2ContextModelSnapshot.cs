﻿// <auto-generated />
using System;
using Dobrin_Catalina_lab2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dobrin_Catalina_lab2.Migrations
{
    [DbContext(typeof(Dobrin_Catalina_lab2Context))]
    partial class Dobrin_Catalina_lab2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dobrin_Catalina_lab2.Models.Authors", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Dobrin_Catalina_lab2.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Dobrin_Catalina_lab2.Models.Publishr", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("Dobrin_Catalina_lab2.Models.Book", b =>
                {
                    b.HasOne("Dobrin_Catalina_lab2.Models.Authors", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID");

                    b.HasOne("Dobrin_Catalina_lab2.Models.Publishr", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Dobrin_Catalina_lab2.Models.Authors", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Dobrin_Catalina_lab2.Models.Publishr", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
