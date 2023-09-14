int takeNumber (string message)
{
Console.WriteLine($"Введите {message} число");
int number = Convert.ToInt32(Console.ReadLine());
return number;
}
void IsPalindrome (int number)
{
if (number < 0) Console.WriteLine("Вы ввели отрицательное число");
else if(number > 9999 && number < 99999) 
{ 
int NumberTemp = number;
int value;
int NumberReverse = 0;
while (NumberTemp > 0) 
{
    value = NumberTemp % 10;
    NumberReverse = NumberReverse * 10 + value;
    NumberTemp /= 10;
}

if (number == NumberReverse) Console.WriteLine("True");
else Console.WriteLine("False");
}
else Console.WriteLine("Вы ввели не пятизначное число");
}
int number = takeNumber("пятизначное");
IsPalindrome(number);

