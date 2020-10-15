using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "LOGITpe20";
            Console.WriteLine($"{someString}");
            string anotherString = someString.Substring(0, 5);
            Console.WriteLine(anotherString);
            string newanotherString = someString.Substring(5, 2);
            Console.WriteLine(newanotherString);
            string AndnewanotherString = someString.Substring(7, 2);
            Console.WriteLine(AndnewanotherString);
           
            
        }
    }
}
