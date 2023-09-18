// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int take(string message)
{
    Console.WriteLine($"Введите {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
void Print(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i + 1 < array.Length) Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine("");
}
int SummPol(int[] array)
{
    int SumPol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) SumPol += array[i];
    }
    return SumPol;
}
int SummOtr(int[] array)
{
    int SumOtr = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) SumOtr += array[i];
    }
    return SumOtr;
}
void PrintSum(string message, int sum)
{
    Console.WriteLine($"Cумма {message} чисел = {sum}");
}

Console.Clear();
int[] array = GetArray(take("размер массива"), take("минимальную границу значений"), take("максимальную границу значений"));
Print(array);
PrintSum("отрицательных", SummOtr(array));
PrintSum("положительных", SummPol(array));