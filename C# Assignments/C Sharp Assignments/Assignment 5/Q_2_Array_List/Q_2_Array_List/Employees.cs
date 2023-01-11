using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_q_2
{
    class Employees
    {
        public int id;
        public string name;
        public double salary;

        public Employees(int id, string name, double salary)
        {
           
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return ($"Employee ID: {id}\nEmployee Name: {name}\nEmployee Salary: {salary}");
        }
    }
}
