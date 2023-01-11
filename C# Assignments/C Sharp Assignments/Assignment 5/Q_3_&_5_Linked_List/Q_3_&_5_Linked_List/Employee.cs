using System;
using System.Collections.Generic;
using System.Text;

namespace Q_3_Linked_List
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;

        public Employee(int id, string name, double salary)
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
