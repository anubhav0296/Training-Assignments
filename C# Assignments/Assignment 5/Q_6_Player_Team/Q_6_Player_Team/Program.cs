using System;

namespace Question6
{
    class Program
    {

        static void Main(string[] args)
        {
            Player[] India = new Player[5]
            {
                new Player("Sachin Tendulkar", 50),
                new Player("Yuvraj Singh", 25),
                new Player("Virat Kohli", 75),
                new Player("M.S.Dhoni", 60),
                new Player("Sehwag", 10),
            };

            Team teamList = new Team(India);
            foreach (Player p in teamList)
                Console.WriteLine(p.name + " " + p.runsScored);
        }
    }
}
