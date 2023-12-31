﻿using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write(matrix[i,j]+ "\t");
  }
  Console.WriteLine();
}

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] matrix = new int[n,m];
for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
                if (j == 0 && i == 0) matrix[i,j] = 1;
                else if (j == 0 && i > 0)  matrix[i, j] = matrix[i - 1, m - 1] + k;
                else matrix[i, j] = matrix[i, j - 1] + k;
  }
}
return matrix;
    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
      int[] results = new int[2];
      if(rowPosition - 1 < matrix.GetLength(0) && columnPosition - 1 < matrix.GetLength(1))
      {
      results[0] = matrix[rowPosition - 1, columnPosition - 1];
      return results;
      }
      else return results; 
}


    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
if (results[0] == 0) Console.WriteLine("There is no such index");
else Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;
           m = 5;
           k = 3;
           x = 2;
           y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}