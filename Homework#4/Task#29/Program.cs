// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int take(string message)
{
    Console.WriteLine($"Enter {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetArray(int min, int max)
{
    int[] array = new int[8];
    Random rand = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;

}
void Print(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]}");
        if (i + 1 < 8) Console.Write(", ");
    }
    Console.Write("]");
}
Print(GetArray(take("min number"), take("maxnumber")));