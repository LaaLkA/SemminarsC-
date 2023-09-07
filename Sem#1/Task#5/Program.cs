// Задание №6. Напишите программу, в которую будет заводиться трёхзначное число, а программа на выходе будет давать последнюю (третью) цифру.
// 324 -> 4
// 111 -> 1

Console.Clear();

Console.WriteLine("Enter three digit number:  ");
string strNumber = Console.ReadLine();
int Number = int.Parse(strNumber);

if (Number > 99)
{
    Console.WriteLine(Number % 10);
}
else
{
    Console.WriteLine("Введите число большее 99");
}
