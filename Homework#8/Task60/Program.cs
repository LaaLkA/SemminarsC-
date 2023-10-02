// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int takeNumbers(string message)
{
    System.Console.WriteLine($"Введите {message}");
    int Number = int.Parse(Console.ReadLine());
    return Number;
}
void GetMatrix(int z, int y, int x)
{
    int[,,] matrix = new int[z, y, x];
    Random rand = new Random();
    int[] nums = new int[matrix.Length];
    for (int m = 0; m < matrix.Length; m++)
    {
    a: nums[m] = rand.Next(10, 100);
        for (int l = nums.Length - 1; l > -1; l--)
        {
            if (nums[m] == nums[l] && l != m) goto a;
        }
    }

    int d = 0;
    for (int i = 0; i < z; i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < x; k++)
            {
                matrix[i, j, k] = nums[d];
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k}) \t");
                d++;
            }
            System.Console.WriteLine();
        }
    }
}

Console.Clear();
GetMatrix(takeNumbers("глубину массива"), takeNumbers("количество строк"), takeNumbers("количество столбцов"));