//Напишите программу, которая принимает на вход два числа и проверяет является ли одно число квадратом другого и наоборот.

Console.Clear();

System.Console.WriteLine("Введите первое число");
string strNumber1 = Console.ReadLine();
int Number1 = int.Parse(strNumber1);

System.Console.WriteLine("Введите второе число");
string strNumber2 = Console.ReadLine();
int Number2 = int.Parse(strNumber2);

if (Number1 * Number1 == Number2 || Number2 * Number2 == Number1) // Используем оператор или "||"
{
   System.Console.WriteLine("Одно из чисел является квадратом другого"); 
}
else 
{
    System.Console.WriteLine("Ни одно из чисел не является квадратом другого");
}