// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное само на себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();

Console.Write("Enter number:   ");
string strNumber = Console.ReadLine();
int number = int.Parse(strNumber);

int sqr = number * number;

Console.WriteLine(sqr);