// Напишите программу, которая будет принимать на вход два числа и выводить, я вляется ли второе кратным первому.  Если число 2 не кратно числу 1, то программа выводит остаток деления.
// 34, 5 -> не кратно, остаток 4
// 16Б 4 -> кратно

Console.Clear();
System.Console.WriteLine("Введите первое число");
string strNumber1 = Console.ReadLine();
int Number1 = int.Parse(strNumber1);

System.Console.WriteLine("Введите второе число");
string strNumber2 = Console.ReadLine();
int Number2 = int.Parse(strNumber2);

if (Number1 % Number2 == 0)
{
    System.Console.WriteLine("Первое число кратно второму!");
}
else 
{
    int residual = Number1 % Number2;
    System.Console.WriteLine($"Первое число не кратно второму. Остаток {residual}");
}