using System;

namespace Assignment_2_OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(14, "Anubhav", 4500);


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
