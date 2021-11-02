using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of empWageBuilder class
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("Infosys", 30, 5, 60);
            empWageBuilder.addCompanyEmpWage("TCs", 25, 6, 70);
            empWageBuilder.computeEmpWage();
           // Console.WriteLine("The total wage for Infosys company is :" + empWageBuilder.getTotalWage("Infosys"));
        }
    }
}
        
    
