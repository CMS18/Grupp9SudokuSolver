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
            //Lätt
            //Sudoku game = new Sudoku("003020600900305001001806400008102900700000008006708200002609500800203009005010300");
            //Sudoku game = new Sudoku("619030040270061008000047621486302079000014580031009060005720806320106057160400030");

            //Medel
            //Sudoku game = new Sudoku("037060000205000800006908000000600024001503600650009000000302700009000402000050360");

            //Diabolic1
            //Sudoku game = new Sudoku("000000000000003085001020000000507000004000100090000000500000073002010000000040009");

            //Diabolic2
            Sudoku game = new Sudoku("900040000000010200370000005000000090001000400000705000000020100580300000000000000");

            //Zen
            //Sudoku game = new Sudoku("000000000000000000000000000000000000000010000000000000000000000000000000000000000");

            //Unsolvables
            //Sudoku game = new Sudoku("009028700806004005003000004600000000020713450000000002300000500900400807001250300");


            game.PrintBoard();
            game.Solve();
            Console.ReadLine();
        }
    }
}
