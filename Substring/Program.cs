﻿using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "interpolation";
            Console.WriteLine($"{someString.Length}");
            string newString = someString.Substring(0, 5);
            Console.WriteLine(newString);
            string andNewString = someString.Substring(5, 8);
            Console.WriteLine(andNewString);
            
                
                
                
            
        }
    }
}
