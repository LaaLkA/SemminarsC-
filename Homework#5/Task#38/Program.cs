// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int take(string message)
{
    Console.WriteLine($"Enter {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double[] GetArray(int size)
{
    Random rand = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next();
    }
    return array;
}
double[] SortArray(double[] array)
{
    double temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}
void PrintMass(double[] array)
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
Console.Clear();
double[] array = GetArray(take("size"));
Console.WriteLine($"Исходный массив:");
PrintMass(array);
double[] SortedArray = SortArray(array);
Console.WriteLine($"Отсортированный массив:");
PrintMass(SortedArray);
Console.WriteLine($"Разница максимального и минимального значения в массиве = {SortedArray[array.Length - 1] - SortedArray[0]}");
