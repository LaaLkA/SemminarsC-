// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] take()
{
    Console.WriteLine("Введите числа через пробел");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Array.ConvertAll (*что конвертирует*, *в какой тип данных конвертирует*) - конвертирует всю строку в масиив
    return array;                                                          // Console.ReadLine().Split() - считываем значения через пробел     
}
int CountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine($"Чисел больше 0 - {CountNum(take())}");