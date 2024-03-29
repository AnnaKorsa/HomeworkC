﻿void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 101); // [1, 20]
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void SortValue(int[,] matrix)
{
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          for (int k = 0;k < matrix.GetLength(1) - 1;k++)
          {
			int temp = 0;
            if (matrix[i, k] < matrix[i, k + 1])
            {
              temp = matrix[i, k + 1];
              matrix[i, k + 1] = matrix[i, k];
              matrix[i, k] = temp;
            }
              
          }
        }
    }
}

Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SortValue(matrix);
PrintMatrix(matrix);