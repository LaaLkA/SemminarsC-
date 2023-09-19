// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Условимся, что индекс 0 соответсвует чётному индексу
int take(string message)
{
    Console.WriteLine($"Enter {message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[] GetArray(int size, int max, int min)
{
    int[] array = new int[size];
    Random rand = new Random();
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
        Console.Write(array[i]);
        if(i + 1 < size) Console.Write(", ");
    }
    Console.Write("]");
    return array;
}
int SumChetPos(int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0) {}
        else Sum += array[i];//В начале мы условились, что нулевой идекс - чётный, если нет, то в условие if нужно дописать "&& i > 0
    }
    return Sum;
}

Console.Clear();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumChetPos(GetArray(take("size"),take("max number"),take("min numbers")))}");