using System;


namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int Is_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            //Random Object
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            //if else condition for checking employee present or absent
            if (empCheck == Is_FULL_TIME)
            {
                Console.WriteLine("Employee type : Full Time");
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee type : Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            //calculation of employee wage
            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("EMPLOYEE WAGE IS :" + empWage);
        }
    }
}