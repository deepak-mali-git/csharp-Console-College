﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10, b = 20;
            //swapping
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadKey();
        }
    }
}
