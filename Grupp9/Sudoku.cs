using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp9
{
    public class Sudoku
    {

        private int[,] gameNumbersArray;

        public Sudoku (string gameNumbers)
        {
            gameNumbersArray = NumbersToBoard(gameNumbers);
        }

        private int[,] NumbersToBoard(string gameNumbers)
        {
            char[] gameNumbersToCharArray = gameNumbers.ToCharArray();
            int[,] gameNumbersToIntArray = new int[9, 9];

            int row = 0;
            int col = 0;

            foreach (char character in gameNumbersToCharArray)
            {
                int numbers = int.Parse(character.ToString());
                gameNumbersToIntArray[row, col] = numbers;

                col++;
                if (col == 9)
                {
                    col = 0;
                    row ++;
                }

            }
            return gameNumbersToIntArray;
        }


        public void PrintBoard()
        {
            PrintBorder();
            for (int row = 0; row < gameNumbersArray.GetLength(0); row++)
            {
                Console.Write("|");
                for (int col = 0; col < gameNumbersArray.GetLength(1); col++)
                {
                    if (col == 3 || col == 6)
                    {
                        Console.Write("|");
                    }
                    Console.Write(gameNumbersArray[row, col]);
                }
                Console.WriteLine("|");


                if (row % 3 == 2)
                {
                    PrintBorder();
                }
            }
           
        }

        public void PrintBorder()
        {
            Console.Write("+");
            for (int col = 0; col-1 < gameNumbersArray.GetLength(1)+1; col++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }








































        /*
        public void StringGameNumbersToCharArray()
        {
            string gameNumbers = "003020600\n900305001\n001806400\n008102900\n700000008\n006708200\n002609500\n800203009\n005010300";
            char[,] gameNumbersChar = new char[9, 9];

            string[] lines = gameNumbers.Split(new[] { '\n' });

            int row = 0;
            foreach (string line in lines)
            {
                int col = 0;
                foreach (char character in line)
                {
                    gameNumbersChar[row, col] = character;
                    col++;
                }
                row++;
            }

        }

        */








    }

	
        
        


        
    
}
