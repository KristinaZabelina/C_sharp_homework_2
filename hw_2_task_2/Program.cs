// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число number");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
    Console.WriteLine("третьей цифры нет");
else
{
    while (number >= 100)
    {
        number = number / 10;
    }

int ThirdNumber = number % 10;
Console.WriteLine(ThirdNumber);
}
