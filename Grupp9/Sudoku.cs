using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp9
{
    public class Sudoku
    {

        private int[,] board = new int[9, 9];

        public Sudoku(string board)
        {
            // TODO: Put string in board
            //  Gå igenom varje tecken i strängen.

            for (int i = 0; i < 9 * 9; i++)
            {
                //   Gör om tecken till siffra.
                int number = int.Parse(board[i].ToString());
                //    Räkna ut rad och kolumn.
                int row = i / 9;
                int col = i % 9;
                //     Skriva in siffra i cell.
                SetCellValue(row, col, number);
            }

        }

        private int GetCellValue(int row, int col)
        {
            return board[row, col];

        }

        private void SetCellValue(int row, int col, int value)
        {
            board[row, col] = value;

        }


        public void PrintBoard()
        {
            PrintBorder();
            for (int row = 0; row < board.GetLength(0); row++)
            {
                Console.Write("|");
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (col == 3 || col == 6)
                    {
                        Console.Write("|");
                    }
                    Console.Write(board[row, col]);
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
            for (int col = 0; col - 1 < board.GetLength(1) + 1; col++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }



        private int[] GetNumbersInRow(int row)
        {
            // Hämta siffrorna i en rad.
            int[] result = new int[9];

            int position = 0;

            for (int col = 0; col < 9; col++)
            {
                int cellValue = GetCellValue(row, col);
                result[position] = cellValue;
                position++;
            }

            return result;

        }

        private int[] GetNumbersInColumn(int col)
        {
            int[] result = new int[9];

            int position = 0;

            for (int row = 0; row < 9; row++)
            {
                int cellValue = GetCellValue(row, col);
                result[position] = cellValue;
                position++;
            }

            return result;

        }


        private int[] GetNumbersInBlock(int row, int col)
        {
            // Beräkna vilket block
            //  Hämta siffrorna i blocket rad för rad

            int[] result = new int[9];
            int topLeftRow = (row / 3) * 3;
            int topLeftCol = (col / 3) * 3;
            int position = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int cellValue = GetCellValue(topLeftRow + i, topLeftCol + j);
                    result[position] = cellValue;
                    position++;
                }
            }

            return result;
        }

        public int[] FindPossibleNumbers(int row, int col)
        {

            // Hitta möjliga tal för cell utifrån rad, kolumn och block.
            List<int> result = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbersInRow = GetNumbersInRow(row);
            int[] numbersInColumn = GetNumbersInColumn(col);
            // int[] numbersInBlock = GetNumbersInBlock(row, col);

            foreach (var number in numbersInRow)
            {
                if (result.Contains(number))
                {
                    result.Remove(number);
                }
            }
            foreach (var number in numbersInColumn)
            {
                if (result.Contains(number))
                {
                    result.Remove(number);
                }
            }
            foreach (var number in GetNumbersInBlock(row, col))
            {
                if (result.Contains(number))
                {
                    result.Remove(number);
                }
            }


            return result.ToArray();

        }

        private bool EmptyCell()
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public void Solve()
        {
            Console.WriteLine("Tryck enter för att lösa. ");
            Console.ReadLine();
            int tries = 0;
            bool sudoku = true;
            do
            {
                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        if (board[row, col] == 0)
                        {
                            var numbers = FindPossibleNumbers(row, col);
                            if (numbers.Length == 1)
                            {
                                board[row, col] = numbers[0];
                            }
                            
                        }
                    }
                }
                tries++;
            } while (tries < 150);
            
            if (TryNumbers())
            {
                PrintBoard();
            }
            //PrintBoard();
        }

        private bool TryNumbers()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        var numbers = FindPossibleNumbers(row, col); 
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            board[row, col] = numbers[i];
                            //Console.SetCursorPosition(0, 0);
                            //PrintBoard();
                            if (TryNumbers())
                            {
                                return true;
                            }
                            else
                            {
                                board[row, col] = 0;
                                //Console.SetCursorPosition(0, 0);
                                //PrintBoard();
                            }
                        }
                        
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
