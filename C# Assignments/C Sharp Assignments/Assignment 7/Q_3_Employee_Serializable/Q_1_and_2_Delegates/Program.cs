using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static Assignment_2_OOPs.Manager;

namespace Assignment_2_OOPs
{
    class Program
    {
        // Serializing
        public static void SerializingObject(object o)
        {
            // Creating a path where you want to make a file to save the object
            string path = @"C:\Users\ANUBHASR\Documents\Training-Assignments\C# Assignments\C Sharp Assignments\Assignment 7\Q_3_Employee_Serializable\Q_1_and_2_Delegates\Output.txt";
            

            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, o);
            stream.Close();
        }
        
        // De - Serializing
        public static void DeSerializingObject()
        {
            string path = @"C:\Users\ANUBHASR\Documents\Training-Assignments\C# Assignments\C Sharp Assignments\Assignment 7\Q_3_Employee_Serializable\Q_1_and_2_Delegates\Output.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Manager m1 = new Manager();
            m1 = (Manager)bf.Deserialize(stream);
            stream.Close();
        }

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

            // Assignment 7 - Q 3, Q 4
            // Calling Serializing method and passing Manager m object in it
            SerializingObject(m);
            
            // Calling DeSerializing method and converting the encoded output.txt to Manager Object
            DeSerializingObject();



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
