using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;

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
                HelloUser(usersID);
                GetYear(usersID);

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
                    Console.WriteLine($"Wrong fromat: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            // || - alt gr + <>
            if(firstNum == 1 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Sir!");

            }else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }
        }

        public static void GetYear(string idCode)
        {
            string yearFromCode = idCode.Substring(1, 2);
            string year;
            if (int.Parse(idCode[0].ToString()) > 4)
            {
                year = "20" + yearFromCode;
            }
            else
            {
                year = "19" + yearFromCode;
        
            }

            Console.WriteLine($"you were born in {year}");

        }


        


    
    
    
    
    
    
    
    
    
    }
}
