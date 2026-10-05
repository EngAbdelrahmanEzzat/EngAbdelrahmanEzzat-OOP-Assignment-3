namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var studentStore = new Store<Student>();

            studentStore.Add(new Student
            {
                Id = 1,
                Name = "Ahmed"
            });

            studentStore.Add(new Student
            {
                Id = 2,
                Name = "Mohamed"
            });

            studentStore.Add(new Student
            {
                Id = 3,
                Name = "Ali"
            });

            studentStore.Add(new Student
            {
                Id = 4,
                Name = "Omar"
            });

            studentStore.Add(new Student
            {
                Id = 5,
                Name = "Mahmoud"
            });


            var courseStore = new Store<Course>();

            courseStore.Add(new Course
            {
                Id = 1,
                Title = "C#"
            });

            courseStore.Add(new Course
            {
                Id = 2,
                Title = "SQL"
            });

            courseStore.Add(new Course
            {
                Id = 3,
                Title = "ASP.NET Core"
            });


            // Get one Student and one Course
            var student = studentStore.GetById(3);
            Console.WriteLine($"Student: {student?.Name}");

            var course = courseStore.GetById(2);
            Console.WriteLine($"Course: {course?.Title}");


            // Duplicate Id
            try
            {
                studentStore.Add(new Student
                {
                    Id = 3,
                    Name = "Another Student"
                });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            // Page 2 - size 2
            Console.WriteLine("\nPage 2:");

            foreach (var studentItem in studentStore.GetAll().Values.Page(2, 2))//هنا .values عشان انا عايز اجيب ال values بس من ال dictionary مش ال keys
            {
                Console.WriteLine($"{studentItem.Id} - {studentItem.Name}");
            }


            // FindById on a plain List<Course>
            var courses = new List<Course>
           {
                new Course
                {
                    Id = 1,
                    Title = "C#"
                },
                new Course
                {
                    Id = 2,
                    Title = "SQL"
                },
                new Course
                {
                    Id = 3,
                    Title = "ASP.NET Core"
                }
            };
            var foundCourse = courses.FindById(2);

            Console.WriteLine($"Found Course: {foundCourse?.Title}");


            // new Store<string>(); // دي مش هيحصلها compile عشان string مش implement IHasId

        }
    }
}
