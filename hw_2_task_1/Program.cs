// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

Console.WriteLine("Введите трехзначное число number");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber = number / 10 % 10;

Console.WriteLine(SecondNumber);