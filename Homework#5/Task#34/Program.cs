// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int take(string message)
{
    Console.WriteLine($"Enter {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next();
        Console.Write($"{array[i]}");
        if(i + 1 < size) Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine("");
    return array;
}
int CountChet(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine($"Количество чётных чисел в массиве = {CountChet(GetArray(take("size")))}");