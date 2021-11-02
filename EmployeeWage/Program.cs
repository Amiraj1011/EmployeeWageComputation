using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of empWageBuilder class
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Infosys", 30, 5, 60);
            empWageBuilder.addCompanyEmpWage("TCs", 25, 6, 70);
            empWageBuilder.computeEmpWage();
        }
    }
}
        
    
