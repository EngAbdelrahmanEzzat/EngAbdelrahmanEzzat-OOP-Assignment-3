namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store<Student> studentStore = new Store<Student>();
            Store<Course> courseStore = new Store<Course>();

            Student s=new Student { Id = 1, Name = "John Doe" };
            studentStore.Add(s);

            Course c = new Course { Id = 1, Title = "C# Programming", Price = 100.00m };
            courseStore.Add(c);

        }
    }
}
