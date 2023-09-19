// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int take()
{
    System.Console.WriteLine("Enter size");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetArray(int size)
{
    Random rand = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 10);
    }
    return array;
}
int[] Revert(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}
void Print(int[] array) //альтернативный вывод Console.WriteLine(string.Join (" ", array));
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i + 1 < array.Length) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

Console.Clear();
int size = take();
int[] array = GetArray(size);
Print(array);
Print(Revert(array));