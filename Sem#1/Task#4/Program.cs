// Задача№5. Напишите программу, которая на вход принимает одно число (N), а на вызоде показывает целые числа в промежутке [-N, N]
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 1 -> "-1, 0, 1"

Console.Clear();

Console.WriteLine("Enter number:   ");
string StrNumber = Console.ReadLine();
int Number = int.Parse(StrNumber);

int massNumber = -Number;

while (massNumber <= Number)
{
    Console.Write(massNumber);
    Console.Write(", ");
    massNumber++;
} 

 