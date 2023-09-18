// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
int[] Switch(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array [i] * -1;
    }
    return array;
}
void print(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i + 1 < array.Length) Console.Write(", ");
    }
    Console.Write("]");
}

Console.Clear();
int[] array = GetArray(take("размер"), take("минимальная грацина значений"), take("максимальная грацина значений"));
print(array);
Switch(array);
print(array);

