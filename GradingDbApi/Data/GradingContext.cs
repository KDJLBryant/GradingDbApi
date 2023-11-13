using GradingDB.Models;
using GradingDbApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingDB.Data
{
    public class GradingContext : DbContext
    {
        public DbSet<Mark> marks { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Group> groups { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Group g1 = new Group() { Id = 1, Name = "Test" };
            Subject sub1 = new Subject() { Id = 1, Title = "Maths" };
            Teacher t1 = new Teacher() { Id = 1, FirstName = "Halla", LastName = "Helgadottir" };
            Student s1 = new Student() { Id = 1, FirstName = "Kyle", LastName = "Bryant", GroupId = 1 };
            Mark m1 = new Mark() { Id = 1, StudentId = 1, SubjectId = 1, mark = 5, DateTime = DateTime.Now };
            TeacherSubject ts = new TeacherSubject() { subject = sub1, teacher = t1 };
            sub1.Marks.Add(m1);

            modelBuilder.Entity<Subject>()
                .HasMany(t => t.Teachers)
                .WithMany(s => s.Subjects)
                .UsingEntity<TeacherSubject>();
            modelBuilder.Entity<Subject>()
                .HasMany(m => m.Marks);

            modelBuilder.Entity<Group>().HasData(g1);
            modelBuilder.Entity<Subject>().HasData(sub1);
            modelBuilder.Entity<Teacher>().HasData(t1);
            modelBuilder.Entity<Student>().HasData(s1);
            modelBuilder.Entity<Mark>().HasData(m1);
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GradingDB");
        }
    }
}
