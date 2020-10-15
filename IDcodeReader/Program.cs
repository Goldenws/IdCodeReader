using System;
using System.Net;

namespace IDcodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code: ");
            string usersID = Console.ReadLine();
            if (Validate(usersID))
            {
                Console.WriteLine("Welcome blyat");
            }
            else
            {
                Console.WriteLine("Wrong format. Try again");

            }
            
        
        
        
        
        
        
        
        } 
        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong fromar: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        


        


    
    
    
    
    
    
    
    
    
    }
}
