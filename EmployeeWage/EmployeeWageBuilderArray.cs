using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    //declaring interface class
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth);
        public void computeEmpWage();
        public int getTotalWage(string company);
    }
    //inheriting from the interfce class
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        //initialising the dictionary object with string as key and the companyempwage class as value
        //initialising the Linkedlist of the referrence type CompanyEmpWage class which holds 
        //all the data about the various variables in it.
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }


    
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //creating emp wage object of the company emp wage class
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company,empRatePerHour,numOfWorkingDays,maxHoursPerMonth); //creating emp wage object of the company emp wage class
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
            //in the above lines of code we are putting the add methods in both the lisrt and dictionary
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                //this will fetch the companyEmpWage object from the list,and the ComputeEmpWage method will execute its with the help of the object's variable
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));    
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        //similar method like compute emp wage that it fethces a single element and then finds out its respected emp wage
        private int ComputeEmpWage(CompanyEmpWage company)
        {
            //variables
            int empWage = 0;
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= company.maxHoursPerMonth && totalWorkingDays < company.numOfWorkingDays)
            {
                totalWorkingDays++;
                //creating random object ob random class
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                //switch case for access employee type
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 4;
                        break;
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                //Formulla for calculating employee wage
                empWage = company.empRatePerHour * totalEmpHrs;
                //formulla for calculating total emp wage
                company.totalEmpWage = company.totalEmpWage + empWage;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs" + empHrs);
             
            }
            return company.totalEmpWage;
        }
            public int getTotalWage(string company)
            {
                return this.companyToEmpWageMap[company].totalEmpWage;
            }      
        
    }
}
