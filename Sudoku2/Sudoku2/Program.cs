using Grupp9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sudoku game = new Sudoku("619030040270061008000047621486302079000014580031009060005720806320106057160400030");

            game.PrintBoard();
            game.Solve();
            Console.ReadLine();
        }
    }
}
