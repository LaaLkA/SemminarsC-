// Задача 35: Задайте одномерный массив из  случайных чисел от 0 до 123. 
// Найдите количество элементов массива, значения которых лежат в отрезке вводимым пользователем.
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
int[] SearchNumbers (int[] array, int min, int max)
{
    int[] arrayNew = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] > min && array[i] < max) arrayNew[i] = array[i];
    }
    return arrayNew;
} 

Console.Clear();
int[] array = GetArray(take ("размер массива"), take ("минимальное значение в массиве"), take ("максимальное значение в массиве"));
PrintArray(array);
PrintArray(SearchNumbers(array, take ("минимальное поисковое значение"), take ("максимальное поисковое значение")));