using System;

namespace Lecture01
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Program.isLeapYear(2000);
        }
        public static bool isLeapYear(int year){
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