//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Enter a number:  ");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

int massNumber = -Number;

while (massNumber <= Number)
{
    if (massNumber % 2 == 0)
    {
        Console.Write(massNumber);
        Console.Write(", ");
        massNumber++; 
    }
    else
    {
        massNumber++;
    } 
} 
