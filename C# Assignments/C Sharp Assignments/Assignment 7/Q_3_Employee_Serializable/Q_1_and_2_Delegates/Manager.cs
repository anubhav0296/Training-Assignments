using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_OOPs
{
    [Serializable]
    class Manager : Employee,IPrintable
    {
        // Making a delegate 
        public delegate void EmployeeDelegates();

        public Manager() { }

        double petrol_allowance;
        double food_allowance;
        double other_allowance;
        double manager_gross_salary;
        double manager_net_salary;

        public double PETROL_ALLOWANCE { 
            get { return this.petrol_allowance; }
            set { this.petrol_allowance = 0.08 * this.SALARY; }
        }
        public double FOOD_ALLOWANCE
        {
            get { return this.food_allowance; }
            set { this.food_allowance = 0.13 * this.SALARY; }
        }
        public double OTHER_ALLOWANCE { 
            get { return this.other_allowance; }
            set { this.other_allowance = 0.03 * this.SALARY; }
        }
        public double MANAGER_GROSS_SALARY { 
            get { return this.manager_gross_salary; }
            set { this.manager_gross_salary = calculate + PETROL_ALLOWANCE + FOOD_ALLOWANCE + OTHER_ALLOWANCE; }
        }
        public override double CalculateSalary() {

            double PF = 0.1 * calculate;
            double TDS = 0.18 * MANAGER_GROSS_SALARY;
            double MANAGER_NET_SALARY = calculate - (PF + TDS);
            return MANAGER_NET_SALARY;
        }


        public Manager(int EmpNo, string EmpName, double Salary)
        {
            this.EMPNO = EmpNo;
            this.EMPNAME = EmpName;
            this.SALARY = Salary;
            this.calculate = calculate;
            this.PETROL_ALLOWANCE = PETROL_ALLOWANCE;
            this.FOOD_ALLOWANCE = FOOD_ALLOWANCE;
            this.OTHER_ALLOWANCE = OTHER_ALLOWANCE;
            this.MANAGER_GROSS_SALARY = MANAGER_GROSS_SALARY;
        }
        public new void printDetails()
        {
            Console.WriteLine("......Printing Details of Manager.....");
            Console.WriteLine($"Employee no: {EMPNO}");
            Console.WriteLine($"Employee name: {EMPNAME}");
            Console.WriteLine($"Employee salary: {SALARY}");
            Console.WriteLine("The Gross Salary of Manager is :" + MANAGER_GROSS_SALARY);
            Console.WriteLine("The Net Salary of Manager is :" + CalculateSalary());
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"EMPLOYEE NUMBER: {EMPNO}, NAME: {EMPNAME}, SALARY: {SALARY}";
        }
    }
    }

