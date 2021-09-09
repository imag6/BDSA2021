using System;

namespace Lecture01
{
    public class Program
    {

        public static void Main(string[] args)
        {   
            var inputString = Console.ReadLine();
            int input = Convert.ToInt32(inputString);

            try 
            {
                bool result = Program.isLeapYear(input);

                if(result == true)
                {
                    Console.WriteLine("yay");
                } else {
                    Console.WriteLine("nay");
                }

            } catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ERROR! The program does not go further back than 1582.");
            }
        
        }
        public static bool isLeapYear(int year){
            if(year < 1582)
            {
                throw new IndexOutOfRangeException();
            }
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                } 
                return true;
            }
            return false;
        }
    }
}