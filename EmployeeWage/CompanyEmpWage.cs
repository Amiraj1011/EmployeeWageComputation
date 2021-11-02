using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class CompanyEmpWage
    {
        //variable declaration
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        
        //Constructor declaration
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            //this.totalEmpWage = totalEmpWage;

        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        //This method returns the total emp wage of the respected company in string format
        public string toString()
        {
            return "Total Employeee Wage for company : " + this.company + " is " + this.totalEmpWage;

        }
    }
}
