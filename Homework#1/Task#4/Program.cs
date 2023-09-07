//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.WriteLine("Enter first number:  ");
string strNumber1 = Console.ReadLine();
int Number1 = int.Parse(strNumber1);

Console.WriteLine("Enter second number:  ");
string strNumber2 = Console.ReadLine();
int Number2 = int.Parse(strNumber2);

Console.WriteLine("Enter third number:  ");
string strNumber3 = Console.ReadLine();
int Number3 = int.Parse(strNumber3);

//Не смог реализовать проверку, если все числа одинаковые
//if (Number1 == Number2)
//{
//    if (Number2 == Number3)
//    {
//    Console.WriteLine("Enter different numbers");
//    }
//    else {}
//}    

if (Number1 > Number2)
{
    if (Number1 > Number3)
    {
        Console.WriteLine("Number 1 is max. ","Max = ", Number1);
    }
    else 
    {
        Console.WriteLine("Number 3 is max. ","Max = ", Number3);
    }
}
else
{
    if (Number2 > Number3)
    {
        Console.WriteLine("Number 2 is max. ","Max = ", Number2);
    }
    else 
    {
        Console.WriteLine("Number 3 is max. ","Max = ", Number3);
    }
    
}