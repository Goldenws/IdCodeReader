using System;

namespace CVVValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your CVV code: ");
            string UserCVV = Console.ReadLine();
            if (Validate(UserCVV))
            {
                Console.WriteLine("Welcome to the Red Line comrade!");
            }

            else 
            {
                Console.WriteLine("Youre About to go to Lubianka Punk!");
            }
        }

        public static bool Validate(string UserCVV)
        {
            if (UserCVV.Length == 3)
            {
                try
                {
                    long.Parse(UserCVV);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
            }   else
            {
                return false;
            } 
           
            
                
            
        }
    }
}
