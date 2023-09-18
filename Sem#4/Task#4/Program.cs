// Напишите программу, которая выводит массив из 8 аргументов, заполненный улями и еденицами в случайном порядке
// [1, 0, 1, 1, 0, 1, 0, 0]

int take(string message)
{
    Console.WriteLine($"Введите {message} массива");
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
void Print (int[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if(i + 1 < length) Console.Write(", ");
    }
    Console.Write("]");
}

Console.Clear();
int[] array = GetArray(take("размер"), take("минимальное значение"), take("макимальное значение"));
Print(array);