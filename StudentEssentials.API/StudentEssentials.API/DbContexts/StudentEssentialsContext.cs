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
        public DbSet<SubjectToShedule> SubjectToShedules { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(s => s.Group)
                .WithMany()
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<User>()
                .HasOne(s => s.Group)
                .WithMany(s => s.UserList)
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<User>()
                .HasKey(s => s.UserId);

            modelBuilder.Entity<Group>()
                .HasOne(s => s.Owner)
                .WithMany()
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Group>()
                .HasMany(s => s.SubjectList)
                .WithOne(s => s.Group)
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<SubjectToShedule>()
                .HasOne(s => s.Group)
                .WithMany(s => s.SubjectList)
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<Message>()
                .HasKey(s => s.MessageId);


            modelBuilder.Entity<Message>().HasData(
                new Message()
                {
                    MessageId = 1,
                    Content = "MessageMessageMessageMessageMessageMessageMessageMessageMessage MessageMessageMessageMessage",
                    Date = new DateTime(),
                    GroupId = 1,
                    UserId = 2
                },
                new Message()
                {
                    MessageId = 2,
                    Content = "45545454 5757457457457547 454575475474",
                    Date = new DateTime(),

                    GroupId = 1,
                    UserId = 1
                },
                new Message()
                {
                    MessageId = 3,
                    Content = "fesfsefsef MessageMessageMessaj46j4j45j54j4geMessage",
                    Date = new DateTime(),

                    GroupId = 1,
                    UserId = 2
                }
                );

            modelBuilder.Entity<SubjectToShedule>().HasData(
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 1,
                   StartTime = new TimeSpan(7, 0, 0),
                   EndTime = new TimeSpan(9, 0, 0),
                   SheduleDay = DayOfWeek.Monday,
                   GroupId = 1,
                   Subject = "Programowanie Webowe",
                   Profesor = "Kazimierz Kądka"
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 2,
                   StartTime = new TimeSpan(9, 0, 0),
                   EndTime = new TimeSpan(11, 0, 0),
                   SheduleDay = DayOfWeek.Monday,
                   GroupId = 1,
                   Subject = "Programowanie Rozproszone",
                   Profesor = "Zbigniew Łysacz"

               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 3,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Monday,
                   GroupId = 1,
                   Subject = "Sztuczna Inteligencja",
                   Profesor = "Zbigniew Nochal"
               },               
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 4,
                   StartTime = new TimeSpan(7, 0, 0),
                   EndTime = new TimeSpan(9, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   GroupId = 1,
                   Subject = "Grafika",
                   Profesor = "Bożena Aleksandrowicz"
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 5,
                   StartTime = new TimeSpan(9, 0, 0),
                   EndTime = new TimeSpan(11, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   GroupId = 1,
                   Subject = "Ping-Pong",
                   Profesor = "Adam Adamowicz"
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 6,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   GroupId = 1,
                   Subject = "Programowanie Niskopoziomowe",
                   Profesor = "Aleksandra Aleksandrowicz"
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 7,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Tuesday,
                   GroupId = 1,
                   Subject = "Programowanie Wysokopoziomowe",
                   Profesor = "Aleksandra Aleksandrowicz"
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 8,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Wednesday,
                   GroupId = 1,
                   Subject = "Algorytmika",
                   Profesor = "Paweł Pawłowski"
               },
               new SubjectToShedule()
               {
                   SubjectToSheduleId = 9,
                   StartTime = new TimeSpan(11, 0, 0),
                   EndTime = new TimeSpan(12, 0, 0),
                   SheduleDay = DayOfWeek.Friday,
                   GroupId = 1,
                   Subject = "Big Data",
                   Profesor = "Aleksandra Aleksandrowicz"
               }

               );

            modelBuilder.Entity<Group>().HasData(
               new Group()
               {
                   GroupId = 1,
                   Name = "Informatyka I-go st sem.1 gr. dziekańska 6 lab. 11",
                   UserId = 1,
               },
               new Group()
               {
                   GroupId = 2,
                   Name = "Informatyka I-go st sem.1 gr. dziekańska 4 lab. 8",
                   UserId = 2,
               },
               new Group()
               {
                   GroupId = 3,
                   Name = "Informatyka I-go st sem.1 gr. dziekańska 1 lab. 3",
                   UserId = 2,
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
