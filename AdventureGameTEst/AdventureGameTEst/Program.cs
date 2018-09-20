using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameTEst
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the The Legend of Z...amie!");
            Console.Write("So what is your name? ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome " + playerName + " You will explore the dungeons of Kallhäll, do your best to escape or you will face death!");
            Console.Read();

        }
    }
}
