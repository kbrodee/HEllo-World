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
            Console.WriteLine($"Ok {Name}, Tell us what year you were born in?");
                string YearBorn = Console.ReadLine();
            Console.WriteLine($"To get this right, {Name} you were born in {YearBorn} Right?");
            Console.ReadKey();
            DateTime now = DateTime.Today;
                String CYear = now.ToString("yyyy");
            int RCY = 0, DOB = 0;

            RCY = Convert.ToInt32(CYear);
            DOB = Convert.ToInt32(YearBorn);

            int AnswerSubtract;

            AnswerSubtract = RCY - DOB;
                        
            Console.WriteLine ($"{Name} you are about "  + AnswerSubtract + " Years Old");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
