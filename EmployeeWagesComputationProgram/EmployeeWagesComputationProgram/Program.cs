using System;

namespace EmployeeWagesComputationProgram
{
    class Program
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int empPerHrs = 20;
        const int No_Working_days = 20;
        const int MAX_HRS_IN_MONTH = 100;

        static void Main(string[] args)
        {



            int empHrs = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;
            //for (int i = 0; i < No_Working_days; i++)
            while (totalEmpHr <= MAX_HRS_IN_MONTH && totalWorkingDays < No_Working_days)
            {
                totalWorkingDays++;
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
                }

                if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                }
                else
                {
                    Console.WriteLine("Absent");
                }*/
                //empWage = empHrs * empPerHrs;
                totalEmpHr += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "emp Hrs" + empHrs);
            }
            int totalEmpWages = totalEmpHr * empPerHrs;
            Console.WriteLine("total wage is=" + totalEmpWages);

        }


    }
}