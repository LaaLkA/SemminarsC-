// Напишите программу, которая выводит случайное трехзначное число и удляет вторую цифру этого числа
// 456 -> 46

Console.Clear();

int Number = new Random().Next(100,1000);
Console.WriteLine($"Полученное случайное трехзначное число: {Number}");

int Number1 = Number / 100;
int Number2 = (Number - Number1*100) / 10;
int Number3 = (Number - Number1*100) % 10;

Console.WriteLine($"Число после удаления второй цифры: {Number1}{Number3}");