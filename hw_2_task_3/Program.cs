// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.WriteLine("Номер дня");
int day = Convert.ToInt32(Console.ReadLine());
if (day % 7 >= 5)
    Console.WriteLine("выходной");
else
    Console.WriteLine("не выходной");