using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet savu dzimsanas dienas datumu!");
            string diena = Console.ReadLine();
            Console.WriteLine("Ievadiet savu dzimsanas menesi!");
            string menesis = Console.ReadLine();
            Console.WriteLine("Ievadiet savu dzimsanas gadu!");
            string gads = Console.ReadLine();
            Console.WriteLine("Jusu dzimsanas diena ir: " + diena + menesis + " " + gads);
            Console.WriteLine("Github test!");
            Console.Read();
        }
    }
}
