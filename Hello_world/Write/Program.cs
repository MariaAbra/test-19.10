﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Hello");
            Console.Write("World");
            string a = Console.ReadLine();
            Console.Write("a");
            Console.ReadKey();


        }
    }
}