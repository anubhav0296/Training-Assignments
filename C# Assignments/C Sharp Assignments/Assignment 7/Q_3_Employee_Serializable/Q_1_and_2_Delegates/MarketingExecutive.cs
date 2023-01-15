using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_OOPs
{
    
    [Serializable]
    class MarketingExecutive : Manager
    {
        double kilometer;
        double tourAllowance;
        double telephoneAllowance = 1000;
        double me_gross_salary;

        public MarketingExecutive(int EmpNo, string EmpName, double Salary, double kilometer)
        {
            this.EMPNO = EmpNo;
            this.EMPNAME = EmpName;
            this.SALARY = Salary;
            this.calculate = calculate;
            this.TOUR_ALLOWANCE = TOUR_ALLOWANCE;
            this.telephoneAllowance = telephoneAllowance;
            this.ME_GROSS_SALARY = ME_GROSS_SALARY;
        }
        public double KILOMETER
        {
            get { return this.kilometer; }
            set { this.kilometer = value; }
        } 
        public double TOUR_ALLOWANCE
        {
            get { return this.tourAllowance; }
            set { this.tourAllowance = 5 * KILOMETER; }
        }
        public double ME_GROSS_SALARY
        {
            get { return this.me_gross_salary; }
            set { this.me_gross_salary = calculate + TOUR_ALLOWANCE + telephoneAllowance ; }
        }
        public override double CalculateSalary()
        {
            double PF = 0.1 * calculate;
            double TDS = 0.18 * ME_GROSS_SALARY;
            double NETSALARY = ME_GROSS_SALARY - (PF + TDS);
            return NETSALARY;
        }

        public new void printDetails()
        {
            Console.WriteLine("......Printing Details of Marketing Executive.....");
            Console.WriteLine($"Employee no: {EMPNO}");
            Console.WriteLine($"Employee name: {EMPNAME}");
            Console.WriteLine($"Employee salary: {SALARY}");
            Console.WriteLine("The Gross Salary of Marketing Executive is :" + ME_GROSS_SALARY);
            Console.WriteLine("The Net Salary of Marketing Executive is :" + CalculateSalary());
            Console.WriteLine();
        }

    }
}
