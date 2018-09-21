using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sudoku game = new Sudoku("003020600900305001001806400008102900700000008006708200002609500800203009005010300");
            //Sudoku game = new Sudoku("619030040270061008000047621486302079000014580031009060005720806320106057160400030");
            Sudoku game = new Sudoku("037060000205000800006908000000600024001503600650009000000302700009000402000050360");

            game.PrintBoard();
            game.Solve();
            Console.ReadLine();
        }
    }
}
