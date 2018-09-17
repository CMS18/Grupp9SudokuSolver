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

        public void Solve()
        {
            int row = 0;
            int col = 0;

            foreach (int cell in gameNumbersArray)
            {
                if (cell == 0)
                {
                    List<int> possibleNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                    for (col = 0; col < gameNumbersArray.GetLength(0); col++)
                    {
                        

                        if (gameNumbersArray[row,col] != 0)
                        {
                            possibleNumbers.Remove(gameNumbersArray[row,col]);

                            if (col == 8)
                            {
                                break;

                            }
                        }

                        

                        
                    }

                    col = 0;

                    for (row = 0; row < gameNumbersArray.GetLength(0); row++)
                    {

                          

                          if (gameNumbersArray[row,col] != 0)
                          {
                                possibleNumbers.Remove(gameNumbersArray[row, col]);
                          }

                            if (row == 8)
                            {
                                break;
                            }

                    }
                }
                /*
                col++;
                if (col == 9)
                {
                    col = 0;
                    row++;
                }*/
            }
        }








































        






    }

	
        
        


        
    
}
