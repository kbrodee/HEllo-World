using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEllo_World
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello! Who are you?");
                string Name = Console.ReadLine();
            Console.WriteLine($"Ok {Name}, Tell us what year where you born in?");
                string YearBorn = Console.ReadLine();
            Console.WriteLine($"To get this right, {Name} you were born in {YearBorn} Right?");
            Console.ReadKey();
            DateTime now = DateTime.Today;
                String CYear = now.ToString("yyyy");
            int num1 = 0, num2 = 0;

            num1 = Convert.ToInt32(CYear);
            num2 = Convert.ToInt32(YearBorn);

            int AnswerSubtract;

            AnswerSubtract = num2 - num1;
                        
            Console.WriteLine ($"{Name} you are about "  + AnswerSubtract + " Years Old");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
