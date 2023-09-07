// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();

Console.WriteLine("Enter number of the day:   ");
string StrNumberDay = Console.ReadLine();
int NumberDay = int.Parse(StrNumberDay);

if (NumberDay == 1)
{
Console.WriteLine("Это Понедельник!");
}
else if (NumberDay == 2)
{
Console.WriteLine("Это Вторник!");
}
else if (NumberDay == 3)
{
Console.WriteLine("Это Среда!");
}
else if (NumberDay == 4)
{
Console.WriteLine("Это Четверг!");
}
else if (NumberDay == 5)
{
Console.WriteLine("Это Пятница!");
}
else if (NumberDay == 6)
{
Console.WriteLine("Это Суббота!");
}
else if (NumberDay == 7)
{
Console.WriteLine("Это Воскресенье!");
}
else 
{
Console.WriteLine("В недели только 7 дней, напишите число от 1 до 7 включительно");
}
 