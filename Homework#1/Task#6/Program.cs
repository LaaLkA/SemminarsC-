//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();

Console.WriteLine("Enter a number:  ");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

if (Number % 2 == 0)
{
    Console.WriteLine("Число чётное!");
}
else 
{
    Console.WriteLine("Число нечётное!");
}