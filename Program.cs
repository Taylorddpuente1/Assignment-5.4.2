// Find sum of right diagnals of a matrix

using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.Write("Input the size of the square matrix: ");
        int matrixsize = Convert.ToInt32(Console.ReadLine());

        int rightDiagonalSum = 0;

        Console.WriteLine("Input elements in the matrix:");
        for (int i = 0; i < matrixsize; i++)
        {
            for (int j = 0; j < matrixsize; j++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if (j == matrixsize - i - 1)
                    rightDiagonalSum += value;
            }
        }

        Console.WriteLine($"\nAddition of the right diagonal elements is: {rightDiagonalSum}");
    }
}


