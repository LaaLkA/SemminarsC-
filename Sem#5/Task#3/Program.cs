// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i + 1 < array.Length) Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int ReturnNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return i;
        }
    }
    return -1;
}
void PrintRes(int i)
{
    if(i == -1) Console.WriteLine($"Нет, искомое число отсутствует!");
    else Console.WriteLine($"Да, искомое число есть! его индекс в массиве = {i}");
}

Console.Clear();
int[] array = GetArray(take("размер массива"), take("минимальное значение массива"), take("максимальное значения массива"));
PrintArray(array);
PrintRes(ReturnNumber(array, take("число для поиска")));