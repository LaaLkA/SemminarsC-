//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Enter first number:  ");
string strNumber1 = Console.ReadLine();
int Number1 = int.Parse(strNumber1);

Console.WriteLine("Enter second number:  ");
string strNumber2 = Console.ReadLine();
int Number2 = int.Parse(strNumber2);
if (Number1 == Number2)
{
    Console.WriteLine("Enter different numbers");
}
else if (Number1 > Number2)
{
    Console.WriteLine("Number 1 is greater than number 2. ","Max = ", Number1);
}
else
{
    Console.WriteLine("Number 2 is greater than number 1. ","Max = ", Number2);
}