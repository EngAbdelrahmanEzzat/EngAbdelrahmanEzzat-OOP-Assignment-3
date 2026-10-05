using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class StudentStore
    {
        public List<Student> Students = new List<Student>();

        public void Add(Student student)
        {
            Students.Add(student);
        }
        public Student? GetById(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null; 
        }
        public void Remove(int id)
        {
            Students.RemoveAll(s => s.Id == id);
        }
        public List<Student> GetAll()
        {
            return Students;
        }


    }
}
