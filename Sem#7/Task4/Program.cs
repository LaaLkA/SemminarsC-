// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int TakeNumber(string message)
{
                System.Console.WriteLine($"Enter {message}");
                int number = int.Parse(Console.ReadLine());
                return number;
}
int[,] GetMatrix(int rows, int columns)
{
                int[,] matrix = new int[rows, columns];
                Random rand = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                                matrix[i, j] = rand.Next(0, 9);
                                }
                }
                return matrix;
}
int SumDiag(int[,] matrix)
{
                int Sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                                if (i == j) Sum += matrix[i, j];
                                                else continue;
                                }
                }
                return Sum;
}
void Print(int[,] matrix)
{
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                                if (i == j)
                                                {
                                                                Console.ForegroundColor = ConsoleColor.Green;//Изменение цвета символов
                                                                System.Console.Write($"{matrix[i, j]} ");
                                                }
                                                else
                                                {
                                                                Console.ForegroundColor = ConsoleColor.Red;//Изменение цвета символов
                                                                System.Console.Write($"{matrix[i, j]} ");
                                                }
                                }
                                System.Console.WriteLine();
                }
}

Console.Clear();
int rows = TakeNumber("Rows");
int columns = TakeNumber("Columns");
int[,] matrix = GetMatrix(rows, columns);
Print(matrix);
Console.ForegroundColor = ConsoleColor.White;//Изменение цвета символов
System.Console.WriteLine($"Сумма элементов матрицы главной диагонали равна {SumDiag(matrix)}");