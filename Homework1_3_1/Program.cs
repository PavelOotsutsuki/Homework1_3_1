using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int countRowsMax = 4;
            int countRowsMin = 2;
            int countColumnsMax = 4;
            int countColumnsMin = 2;
            int randomNumberMin = 0;
            int randomNumberMax = 9;
            int countRows = random.Next(countRowsMin, countRowsMax+1);
            int countColumns = random.Next(countColumnsMin, countColumnsMax+1);
            int productFirstColumn=1;
            int sumSecondRow = 0;
            int firstColumn = 0;
            int secondRow = 1;
            int[,] array = new int[countRows, countColumns];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    array[row, column] = random.Next(randomNumberMin, randomNumberMax+1);
                }
            }

            for (int column=0; column < array.GetLength(1); column++)
            {
                sumSecondRow += array[secondRow, column];
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                productFirstColumn *= array[row, firstColumn];
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Сумма " + (secondRow + 1) + " строки: " + sumSecondRow);
            Console.WriteLine("Произведение " + (firstColumn + 1) + " столбца: " + productFirstColumn);
        }
    }
}