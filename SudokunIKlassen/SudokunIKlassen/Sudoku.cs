using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokunIKlassen
{
    internal class Sudoku
    {
        private int[,] board = new int[9, 9];

        public Sudoku(string board)
        {
            // TODO: Put string i board

            // Gå igenom varje tecken(char) i strängen
            //   Gör om tecken till siffra
            //   Räkna ut rad och kolumn
            //   Skriva in siffra i cell

            for (int i = 0; i < board.Length; i++)
            {
                int number = int.Parse(board[i].ToString());
                int row = i / 9;
                int col = i % 9;

                SetCellValue(row, col, number);
            }

            /*int position = 0;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int number = int.Parse(board[position].ToString());
                    SetCellValue(row, col, number);
                    position++;
                }

            }

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    position = (row * 9) + col;
                    int number = int.Parse(board[position].ToString());
                    SetCellValue(row, col, number);
                }

            }*/

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
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int cellValue = GetCellValue(row, col);

                        if (cellValue != 0)
                        {
                            Console.Write(cellValue + " ");
                        }
                        else
                        {
                            Console.Write("_ ");
                        }
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            
            // Loopa rader
            //   Loopa kolumner
            //    Lägg in siffra i builder
            //  Ny rad

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int cellValue = GetCellValue(row, col);
                  
                    if (cellValue == 0)
                    {
                        builder.Append("_ ");
                    }
                    else
                    {
                        builder.Append(cellValue + " ");
                    }
                }
                builder.AppendLine();
            }

            return builder.ToString();
        }
        
        private bool CellIsEmpty(int row, int col)
        {
            // Hämta värdet på cell i rad och kolumn
            // Om (cell == 0) så är den tom
            throw new NotImplementedException();
        }

        private int[] GetNumbersInRow(int row)
        {
            // Hämta siffrorna i en rad

            throw new NotImplementedException();
        }

        private int[] GetNumbersInCol(int col)
        {
            // Hämta siffrorna i en col

            throw new NotImplementedException();
        }

        private int[] GetNumbersInBlock(int row, int col)
        {
            // Beräkna vilket block
            // Hämta siffrorna i blocket rad för rad

            int[] result = new int[9];

            int topLeftRow = (row < 3) ? 0 : ((row < 6 )? 3 : 6);
            int topLeftColumn = (col / 3) * 3;

            int position = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int cellValue = GetCellValue(topLeftRow + i, topLeftColumn + j);
                    result[position] = cellValue;
                    position++;
                }
            }

            return result;
            
        }

        public int[] FindPossibleNumbers(int row, int col)
        {
            List<int> result = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] numbersInRow = GetNumbersInRow(row);
            int[] numbersInCol = GetNumbersInCol(col);

            foreach (var number in numbersInRow)
            {
                if (result.Contains(number))
                {
                    result.Remove(number);
                }
            }
            foreach (var number in numbersInCol)
            {
                if (result.Contains(number))
                {
                    result.Remove(number);
                }
            }
            foreach (var number in GetNumbersInBlock(row,col))
            {
                if (result.Contains(number))
                {
                    result.Remove(number);
                }
            }

            return result.ToArray();
        }

        private bool IsComplete()
        {
            //Loopa igenom alla celler
            // Om (cell är tom) inte färdig
            throw new NotImplementedException();
        }

        public void Solve()
        {
            // Loopa tills färdig (dvs inga tomma rutor)
            //     Loopa igenom alla celler (for-loop nestade rad och kolumn)
            //       Om (cell är tom)
            //         Hitta möjliga tal för cell utifrån rad, kolumn och block
            //         Om (noll alternativ för cellen) finns ingen lösning - avbryta
            //         Om (ett alternativ) skriv in tal i cell
            //         Om (flera alternativ för cellen) gå vidare


            throw new NotImplementedException();
        }
    }
}
