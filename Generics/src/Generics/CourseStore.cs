using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class CourseStore
    {
        public List<Course> Courses = new List<Course>();

        public void Add(Course course)
        {
            Courses.Add(course);
        }
        public Course? GetById(int id)
        {
            foreach (var course in Courses)
            {
                if (course.Id == id)
                {
                    return course;
                }
            }
            return null;
        }
        public void Remove(int id)
        {
            Courses.RemoveAll(c => c.Id == id);
        }
        public List<Course> GetAll()
        {
            return Courses;
        }

    }
}
