// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int TakeNumbers(string message)
{
    Console.WriteLine($"Enter {message}");
    int numbers = int.Parse(Console.ReadLine());
    return numbers;
}

void GetSpiralMatrix(int N, int M)
{
int[,] a = new int[N, M];
int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

int Numb = 1;// Начальное значение массива matrix[0,0]
int i = 0; // Положение по строкам
int j = 0; // положение по столбцам

while (Numb <= N * M)
{
    a[i, j] = Numb;
    if (i == Ibeg && j < M - Jfin - 1)
        ++j;
    else if (j == M - Jfin - 1 && i < N - Ifin - 1)
        ++i;
    else if (i == N - Ifin - 1 && j > Jbeg)
        --j;
    else
        --i;

    if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
    {
        ++Ibeg;
        ++Ifin;
        ++Jbeg;
        ++Jfin;
    }
    ++Numb;
}

for (int g = 0; g < N; ++g)
{
    for (int l = 0; l < M; ++l)
        {
            System.Console.Write(a[g,l] + "\t");
        }
        System.Console.WriteLine();
}
}

Console.Clear();
int N = TakeNumbers("N size of matrix(count rows)");
int M = TakeNumbers("M size of mateix(count colums)");
GetSpiralMatrix(N, M);