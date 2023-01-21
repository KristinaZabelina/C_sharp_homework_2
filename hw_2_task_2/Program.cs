// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное число number");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 > 0)
{
    int ThirdNumber = number % 10;
    Console.WriteLine(ThirdNumber);
}
else
    Console.WriteLine("третьей цифры нет");
