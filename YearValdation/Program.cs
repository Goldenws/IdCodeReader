using System;
using System.ComponentModel.DataAnnotations;

namespace YearValdation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth");
            string UserInput = Console.ReadLine();
            if (Validate(UserInput))
            {
                CalcualteAge(UserInput);
            }
      
 
      
        }
         public static bool Validate(string yearInput)
        {
            if(yearInput.Length == 4)
            {
                try
                {
                    Int32.Parse(yearInput);
                    Console.WriteLine("All Good.");
                    return true;
                }catch(Exception error)
                {
                    Console.WriteLine(error);
                    return false;
                }

        
          
            }
          else
            {
                Console.WriteLine("Wrong Format");
                return false;
            }
        }

        public static void CalcualteAge(string yearInput)
        {
            int year = Int32.Parse(yearInput);

            DateTime now = DateTime.Now;
            string currentYear = now.Year.ToString();
            int yearNow = Int32.Parse(currentYear);
            int age = yearNow - year;
            Console.WriteLine($"You are {yearNow} - {age} years old");
        }


    
    
    
    
    }








}
