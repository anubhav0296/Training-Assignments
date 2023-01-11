using System;
using System.Collections.Generic;

namespace Q_3_Linked_List
{
    class Program
    {
        // Q - 3
        //a. Add a new employee
        //b. Display the list of employees.
        //c. Total number of employees in the list

        // Q - 5
        // In the assignment 3 above, add a functionality to search an employee on name in the List<>
        static void Main(string[] args)
        {
            // Enter the number of Employees for whom you want to store data
            Console.WriteLine("Enter the number of emplyees whose data you want to store");
            int size = Convert.ToInt32(Console.ReadLine());

            // The following adds objects of the Employee class in the
            // List<Employee>
            List<Employee> empList = new List<Employee>();

            // Run a loop to store data of each employees
            for (int i = 0; i < size; i++)
            {
                // Taking input from user about id, name and salary
                Console.WriteLine("Enter employee id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter employee name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter employee salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                // Make an object of Employee data and then add it to arrayList
                Employee empData = new Employee(id, name, salary);

                // Add individual employee data to an ArrayList
                empList.Add(empData);
            }

            // Displaying employee details
            Console.WriteLine("Displaying Employee details-----");
            foreach (object obj in empList)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine($"Total number of employees are: {size}");


            //searching the name of the employee
            Console.WriteLine("Enter the name of the employee you want to search");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (Employee e in empList)
            {
                if (e.name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
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
