﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEssentials.API.DbContexts;

namespace StudentEssentials.API.Migrations
{
    [DbContext(typeof(StudentEssentialsContext))]
    [Migration("20201107140617_ChangedSubjectToSheduleModel")]
    partial class ChangedSubjectToSheduleModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentEssentials.API.Entities.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("SheduleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "Informatyka I-go st sem.1 gr. dziekańska 6 lab. 11",
                            SheduleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "Informatyka I-go st sem.1 gr. dziekańska 4 lab. 8",
                            SheduleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            GroupId = 3,
                            Name = "Informatyka I-go st sem.1 gr. dziekańska 1 lab. 3",
                            SheduleId = 1,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("StudentEssentials.API.Entities.Shedule", b =>
                {
                    b.Property<int>("SheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("SheduleId");

                    b.ToTable("Shedules");

                    b.HasData(
                        new
                        {
                            SheduleId = 1
                        });
                });

            modelBuilder.Entity("StudentEssentials.API.Entities.SubjectToShedule", b =>
                {
                    b.Property<int>("SubjectToSheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Profesor")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("SheduleDay")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<int>("SheduleId")
                        .HasColumnType("int");

                    b.Property<int?>("SheduleId1")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time")
                        .HasMaxLength(50);

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("SubjectToSheduleId");

                    b.HasIndex("SheduleId");

                    b.HasIndex("SheduleId1");

                    b.ToTable("SubjectToShedules");

                    b.HasData(
                        new
                        {
                            SubjectToSheduleId = 1,
                            EndTime = new TimeSpan(0, 9, 0, 0, 0),
                            Name = "Programowanie Webowe",
                            Profesor = "Kazimierz Kądka",
                            SheduleDay = 1,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 7, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 2,
                            EndTime = new TimeSpan(0, 11, 0, 0, 0),
                            Name = "Programowanie Rozproszone",
                            Profesor = "Zbigniew Łysacz",
                            SheduleDay = 1,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 3,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Name = "Sztuczna Inteligencja",
                            Profesor = "Zbigniew Nochal",
                            SheduleDay = 1,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 4,
                            EndTime = new TimeSpan(0, 9, 0, 0, 0),
                            Name = "Grafika",
                            Profesor = "Bożena Aleksandrowicz",
                            SheduleDay = 2,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 7, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 5,
                            EndTime = new TimeSpan(0, 11, 0, 0, 0),
                            Name = "Ping-Pong",
                            Profesor = "Adam Adamowicz",
                            SheduleDay = 2,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 6,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Name = "Programowanie Niskopoziomowe",
                            Profesor = "Aleksandra Aleksandrowicz",
                            SheduleDay = 2,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 7,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Name = "Programowanie Wysokopoziomowe",
                            Profesor = "Aleksandra Aleksandrowicz",
                            SheduleDay = 2,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 8,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Name = "Algorytmika",
                            Profesor = "Paweł Pawłowski",
                            SheduleDay = 3,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            SubjectId = 0
                        },
                        new
                        {
                            SubjectToSheduleId = 9,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            Name = "Big Data",
                            Profesor = "Aleksandra Aleksandrowicz",
                            SheduleDay = 5,
                            SheduleId = 1,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0),
                            SubjectId = 0
                        });
                });

            modelBuilder.Entity("StudentEssentials.API.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId1")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("GroupId");

                    b.HasIndex("GroupId1");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "test@test.com",
                            FirstName = "Test",
                            GroupId = 1,
                            LastName = "User",
                            Password = "test",
                            Role = 0
                        },
                        new
                        {
                            UserId = 2,
                            Email = "test2@test.com",
                            FirstName = "Test2",
                            GroupId = 1,
                            LastName = "User2",
                            Password = "test",
                            Role = 0
                        },
                        new
                        {
                            UserId = 3,
                            Email = "test3@test.com",
                            FirstName = "Test3",
                            GroupId = 1,
                            LastName = "User3",
                            Password = "test",
                            Role = 0
                        });
                });

            modelBuilder.Entity("StudentEssentials.API.Entities.SubjectToShedule", b =>
                {
                    b.HasOne("StudentEssentials.API.Entities.Shedule", "Shedule")
                        .WithMany()
                        .HasForeignKey("SheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentEssentials.API.Entities.Shedule", null)
                        .WithMany("SubjectList")
                        .HasForeignKey("SheduleId1");
                });

            modelBuilder.Entity("StudentEssentials.API.Entities.User", b =>
                {
                    b.HasOne("StudentEssentials.API.Entities.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("StudentEssentials.API.Entities.Group", null)
                        .WithMany("UserList")
                        .HasForeignKey("GroupId1");
                });
#pragma warning restore 612, 618
        }
    }
}
