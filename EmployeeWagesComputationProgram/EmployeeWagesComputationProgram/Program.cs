using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            int empPerHrs = 20;

            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();

            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Full Time");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Part Time");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Absent");
                    empHrs = 0;
                    break;
            }

            /*if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Full Time");
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Part Time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Absent");
            }*/

            /*if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Absent");
            }*/
            empWage = empHrs * empPerHrs;
            Console.WriteLine(+empWage);

        }
    }
}
