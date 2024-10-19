using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "maria";
            int age = 15;
            bool isEmployed = false;
            double weight = 90;
            Console.WriteLine("имя:{ name}");
            Console.WriteLine($"возраст {age}");
            Console.WriteLine($"вес: {weight}");
            Console.WriteLine($"работает: {isEmployed} ");


        }
    }
}
