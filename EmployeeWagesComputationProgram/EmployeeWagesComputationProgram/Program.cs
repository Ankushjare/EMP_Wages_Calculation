using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int empPerHrs = 20;

            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Absent");
                empHrs = 0;
            }
            empWage = empHrs * empPerHrs;
            Console.WriteLine(+empWage);

        }
    }
}
