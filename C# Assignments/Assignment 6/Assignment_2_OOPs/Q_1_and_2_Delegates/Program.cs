using System;
using static Assignment_2_OOPs.Manager;

namespace Assignment_2_OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking input from user - id, name, salary, kilometer
            Console.WriteLine("Enter id of employee: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name of employee: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter salary of employee: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter kilometer employee has traveled: ");
            double kilometer = Convert.ToDouble(Console.ReadLine());



            // Creating Employee object
            Employee emp = new Employee(id, name, salary);
            emp.CalculateSalary();
            //emp.printDetails();

            // Creating Manager Object
            Manager m = new Manager(id, name, salary);
            m.CalculateSalary();
            //m.printDetails();

            // Creating Marketing Executive
            MarketingExecutive me = new MarketingExecutive(id, name, salary, kilometer);
            me.CalculateSalary();
            //me.printDetails();

            // Craeting a delegate and adding 1 delegate first. Then another delegate is added leading to 
            // Multi - Cast delegate
            EmployeeDelegates obj = new EmployeeDelegates(m.printDetails);
            //obj(); // UnitCast Delegates
            obj += me.printDetails; // Adding one more method (reference) to this delegate object
            obj(); // Displaying Multi Cast Delegate





            // This is for input that is given, it doesn't takes input from user
            // We can also directly print or display calculate Property or else we have
            // to use a method to display 
            //emp.calculate = 4500;
            //Console.WriteLine("The Gross Salary is: "+emp.calculate);

            //emp.printDetails();
            //Console.WriteLine(emp.CalculateSalary());


            //Employee emp = new Employee();
            //emp.Salary = 4500;
            //Console.WriteLine(emp.calculate());

            //Manager mg = new Manager(14, "Anubhav", 4500);
            //mg.printDetails();

            //MarketingExecutive me = new MarketingExecutive(14, "Anubhav", 4500, 50);
            //me.printDetails();


            Console.ReadKey();

        }
    }
}
