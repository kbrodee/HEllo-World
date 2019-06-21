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
            Console.WriteLine($"To get this right you where born in {YearBorn} ?");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
