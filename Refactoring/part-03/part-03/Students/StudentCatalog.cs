using System;
using System.Collections.Generic;
using System.Text;

namespace part_03.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }

    public static class StudentCatalog
    {
        public static IEnumerable<Student> GetAllStudents()
        {
            var students = new List<Student>();
            for (var i = 1; i <= 1_000_000; i++)
            {
                yield return new Student
                {
                    Id = i,
                    Name = $"Student {i}"
                };
            }
        }
    }

}
