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
            int countRows = random.Next(2, 5);
            int countColumns = random.Next(2, 5);
            int productFirstColumn=1;
            int sumSecondRow = 0;
            int firstColumn = 0;
            int secondRow = 1;
            int[,] array = new int[countRows, countColumns];

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    array[row, column] = random.Next(0, 10);
                }
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(array[row, column] + " ");

                    if (row == secondRow)
                    {
                        sumSecondRow += array[row, column];
                    }

                    if (column== firstColumn)
                    {
                        productFirstColumn*=array[row, column];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Сумма " + (secondRow + 1) + " строки: " + sumSecondRow);
            Console.WriteLine("Произведение " + (firstColumn + 1) + " столбца: " + productFirstColumn);
        }
    }
}