using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_OOPs
{
    interface IPrintable
    {
        void printDetails();
    }
    [Serializable]
    public class Employee : IPrintable
    {
        int EmpNo;
        string EmpName;
        double Salary;
        double HRA;
        public double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;


        //EmpNo, EmpName and Salary -- 
        public Employee() { }
        public int EMPNO {
            get {
                return this.EmpNo;
            }
            set {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("Invalid Employee No");
                    }
                    this.EmpNo = value;
                }
                catch
                {
                    Console.WriteLine("Invalid Employee No");
                    Environment.Exit(1);
                }
            }
        }
        public string EMPNAME {
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("The name is Null");
                    }
                    this.EmpName = value;
                }
                catch
                {
                    Console.WriteLine("The name is Null");
                    Environment.Exit(1);
                }
            }
            get { return this.EmpName; }
        }
        public double SALARY {
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Salary can't be negative");
                    }
                    this.Salary = value;
                }
                catch
                {
                    Console.WriteLine("Salary can't be negative");
                    Environment.Exit(1);
                }
            }
            get { return this.Salary; }
        }

        // Make a calculate to get and set GrossSalary provided Salary
        public double calculate {
            set { if (Salary < 5000)
                {
                    this.HRA = 0.1 * Salary;
                    this.TA = 0.05 * Salary;
                    this.DA = 0.15 * Salary;
                    this.GrossSalary = this.Salary + HRA + TA + DA;
                }
                else if (Salary >= 5000 && Salary < 10000)
                {
                    this.HRA = 0.15 * Salary;
                    this.TA = 0.1 * Salary;
                    this.DA = 0.2 * Salary;
                    this.GrossSalary = this.Salary + HRA + TA + DA;
                }
                else if (Salary >= 10000 && Salary < 15000)
                {
                    this.HRA = 0.2 * Salary;
                    this.TA = 0.15 * Salary;
                    this.DA = 0.25 * Salary;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary >= 20000)
                {
                    this.HRA = 0.3 * Salary;
                    this.TA = 0.25 * Salary;
                    this.DA = 0.35 * Salary;
                    this.GrossSalary = this.Salary + HRA + TA + DA;
                }
            }
            get { return this.GrossSalary; }
        }

        // Made a Constructor and passed the three inputs
        public Employee(int EmpNo, string EmpName, double Salary)
        {
            this.EMPNO = EmpNo;
            this.EMPNAME = EmpName;
            this.SALARY = Salary;
            this.calculate = calculate;
        }

        //Calculate PF, TDS and Net salary in a function named “CalculateSalary()”
        public virtual double CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
            return NetSalary;
        }

        public virtual void printDetails()
        {
            Console.WriteLine(".......Printing Details of Employee.....");
            Console.WriteLine($"Employee no: {EMPNO}");
            Console.WriteLine($"Employee name: {EMPNAME}");
            Console.WriteLine($"Employee salary: {SALARY}");
            Console.WriteLine($"The Gross Salary of Employee is :" + calculate);
            Console.WriteLine($"The Net Salary of Employee is :" + CalculateSalary());
            Console.WriteLine();
        }
    }
    
}
