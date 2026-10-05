using System.Text.RegularExpressions;
namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string s= "01012345678"; 
           Console.WriteLine(s.IsValidEgyptianPhone());

            string t = "+201012345678";
            Console.WriteLine(t.IsValidEgyptianPhone());



            string nationalId = "29812345678901";
            Console.WriteLine(nationalId.IsValidEgyptianNationalId());

        }
    }
}
