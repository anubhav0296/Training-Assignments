using System;
using System.IO;

namespace Ass_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICIBank icici_cust = new ICICIBank();
            icici_cust.acceptDetails("ICICI Bank");
            icici_cust.Withdraw(6000, icici_cust.UnderBalance, icici_cust.BalanceZero);
            icici_cust.Deposit(4000);
            icici_cust.Withdraw(60000, icici_cust.UnderBalance, icici_cust.BalanceZero);

            HDFCBank hdfc_cust = new HDFCBank();
            hdfc_cust.acceptDetails("HDFC Bank");
            hdfc_cust.Withdraw(43000, hdfc_cust.UnderBalance, hdfc_cust.BalanceZero);


            StreamReader s = new StreamReader(@"C:\Users\RAKERKAR\.Net-FullStack\C# Assignments\Assignment_6\Question3\output.txt");
            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
        }
    }
}
