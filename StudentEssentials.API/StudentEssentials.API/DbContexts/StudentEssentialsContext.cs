using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StudentEssentials.API.Entities;

namespace StudentEssentials.API.DbContexts
{
    public class StudentEssentialsContext : DbContext
    {
        public StudentEssentialsContext(DbContextOptions<StudentEssentialsContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<Shedule> Shedules { get; set; }
        public DbSet<SubjectToShedule> SubjectToShedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(s => s.Group)
                .WithMany()
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<User>()
                .HasKey(s => s.UserId);


            modelBuilder.Entity<Shedule>()
                .HasMany(s => s.SubjectList)
                .WithOne(s => s.Shedule)
                .HasForeignKey(s => s.SheduleId);

            modelBuilder.Entity<SubjectToShedule>()
                .HasOne(s => s.Shedule)
                .WithMany(s => s.SubjectList)
                .HasForeignKey(s => s.SheduleId);

            modelBuilder.Entity<SubjectToShedule>()
                .HasOne(s => s.Subject)
                .WithMany()
                .HasForeignKey(s => s.SubjectId);

            modelBuilder.Entity<Shedule>().HasData(
                new Shedule()
                {
                    SheduleId = 1
                }
                );

            modelBuilder.Entity<Subject>().HasData(
               new Subject()
               {
                   SubjectId = 1,
                   Name = "Programowanie Webowe",
                   Profesor = "Kazimierz Kądka"
               },
                new Subject()
                {
                    SubjectId = 2,
                    Name = "Programowanie Niskopoziomowe",
                    Profesor = "Aleksandra Aleksandrowicz"
                },
                 new Subject()
                 {
                     SubjectId = 3,
                     Name = "Programowanie Rozproszone",
                     Profesor = "Zbigniew Łysacz"
                 }
               );            
            
            modelBuilder.Entity<SubjectToShedule>().HasData(
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 1,
                   StartTime = new TimeSpan(7, 0, 0),
                   EndTime = new TimeSpan(9, 0, 0),
                   SheduleDay = DayOfWeek.Monday,
                   SubjectId = 1,
                   SheduleId = 1
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 2,
                   StartTime = new TimeSpan(9, 0, 0),
                   EndTime = new TimeSpan(11, 0, 0),
                   SheduleDay = DayOfWeek.Monday,
                   SubjectId = 2,
                   SheduleId = 1
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 3,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Monday,
                   SubjectId = 3,
                   SheduleId = 1
               },               
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 4,
                   StartTime = new TimeSpan(7, 0, 0),
                   EndTime = new TimeSpan(9, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   SubjectId = 1,
                   SheduleId = 1
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 5,
                   StartTime = new TimeSpan(9, 0, 0),
                   EndTime = new TimeSpan(11, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   SubjectId = 2,
                   SheduleId = 1
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 6,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   SubjectId = 3,
                   SheduleId = 1
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 7,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   SubjectId = 3,
                   SheduleId = 1
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 8,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Wednesday,
                   SubjectId = 3,
                   SheduleId = 1
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 9,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Friday,
                   SubjectId = 3,
                   SheduleId = 1
               }

               );

            modelBuilder.Entity<Group>().HasData(
               new Group()
               {
                   GroupId = 1,
                   Name = "Informatyka I-go st sem.1 gr. dziekańska 6 lab. 11",
                   UserId = 1,
                   SheduleId = 1
               },
               new Group()
               {
                   GroupId = 2,
                   Name = "Informatyka I-go st sem.1 gr. dziekańska 4 lab. 8",
                   UserId = 2,
                   SheduleId = 1
               },
               new Group()
               {
                   GroupId = 3,
                   Name = "Informatyka I-go st sem.1 gr. dziekańska 1 lab. 3",
                   UserId = 2,
                   SheduleId = 1
               }

               );

            modelBuilder.Entity<User>().HasData(
              new User()
              {
                  UserId = 1,
                  FirstName = "Test",
                  LastName = "User",
                  Email = "test@test.com",
                  GroupId = 1,
                  Password = "test"
              },
               new User()
               {
                   UserId = 2,
                   FirstName = "Test2",
                   LastName = "User2",
                   Email = "test2@test.com",
                   GroupId = 1,
                   Password = "test"
               },
                new User()
                {
                    UserId = 3,
                    FirstName = "Test3",
                    LastName = "User3",
                    Email = "test3@test.com",
                    GroupId = 1,
                    Password = "test"
                }

              ); 

           








            base.OnModelCreating(modelBuilder);

        }
    }
}
