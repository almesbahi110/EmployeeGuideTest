﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("JobTypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobTypeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(7017),
                            JobTypeId = 1L,
                            Name = "Mohammed Al-Mesbahi",
                            State = 1
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(7020),
                            JobTypeId = 2L,
                            Name = "Ali ali",
                            State = 1
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(7021),
                            JobTypeId = 3L,
                            Name = "ali 2",
                            State = 1
                        });
                });

            modelBuilder.Entity("JobType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JobTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(6973),
                            Name = "Devloper C#",
                            State = 1
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(6986),
                            Name = "Devloper ASP.NET Core",
                            State = 1
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 10, 16, 14, 0, 3, 220, DateTimeKind.Local).AddTicks(6987),
                            Name = "Devloper Angular",
                            State = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.HasOne("JobType", "JobType")
                        .WithMany("Employees")
                        .HasForeignKey("JobTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobType");
                });

            modelBuilder.Entity("JobType", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
