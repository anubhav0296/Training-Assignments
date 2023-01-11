using System;
using System.Collections.Generic;

namespace Assignment_5_q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();

            Console.WriteLine("Enter the number of employees you want to save");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter employee {i + 1}'s data");
                Console.WriteLine("Enter ID");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Salary");
                double sal = Convert.ToDouble(Console.ReadLine());

                //creating employee object
                li.Add(new Employee(id, name, sal));
            }
            Console.WriteLine("------Displaying Employee List------");
            foreach (Employee e in li)
            {
                Console.WriteLine(e + "\n");
            }
            Console.WriteLine($"List contains {li.Count} Employee records.");

            //searching the name of the employee
            Console.WriteLine("Enter the name of the employee you want to search");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (Employee e in li)
            {
                if (e.empName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
            }
            Console.WriteLine(found == true ? "Employee found." : "No record found.");
        }
    }
}
