using System;
using System.Collections;

namespace Assignment_5_q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter the number of Employees for whom you want to store data
            Console.WriteLine("Enter the number of emplyees whose data you want to store");
            int size = Convert.ToInt32(Console.ReadLine());

            // Use ArrayList - Non generic collection to store data of Employees
            ArrayList empList = new ArrayList();

            // Run a loop to store data of each employees
            for(int i = 0; i < size; i++)
            {
                // Taking input from user about id, name and salary
                Console.WriteLine("Enter employee id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter employee name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter employee salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                // Make an object of Employee data and then add it to arrayList
                Employees empData = new Employees(id, name, salary);

                // Add individual employee data to an ArrayList
                empList.Add(empData);
            }

            // Displaying employee details
            Console.WriteLine("Displaying Employee details-----");
            foreach(object obj in empList)
            {
                Console.WriteLine(obj + " ");
            }
        }
    }
}
