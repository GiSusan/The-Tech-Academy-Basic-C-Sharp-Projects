using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_database
{
    internal class Program
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public byte[] Photo { get; set; }
            public decimal Height { get; set; }
            public float Weight { get; set; }

            public Grade Grade { get; set; }
        }

        public class Grade
        {
            public int GradeId { get; set; }
            public string GradeName { get; set; }
            public string Section { get; set; }

            public ICollection<Student> Students { get; set; }
        }

        public class SchoolContext : DbContext
        {
            public SchoolContext() : base()
            {

            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Grade> Grades { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name:");
            string studentName = Console.ReadLine();

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = studentName };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            Console.WriteLine("Student added successfully.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
