// Запишите 45: Напишите программу, которая будет создавать копию заданного массима
// с помощью поэлементного копирования.

int take()
{
    System.Console.WriteLine("Enter size");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next();
    }
    return array;
}
int[] CopyArray(int[] array)
{
    int[] CopiedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        CopiedArray[i] = array[i];
    }
    return CopiedArray;
}
// void Print(int[] array)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}");
//         if (i + 1 < array.Length) System.Console.Write(", ");
//     }
//     System.Console.Write("]");
//     System.Console.WriteLine(" ");
// }

Console.Clear();

int[] array = GetArray(take());
System.Console.WriteLine("Исходный массив:");
// Print(array);
System.Console.WriteLine(string.Join(" ", array));

System.Console.WriteLine("Скопированный масиив:");
int[] CopiedArray = CopyArray(array);
// Print(CopiedArray);
System.Console.WriteLine(string.Join(" ", CopiedArray));