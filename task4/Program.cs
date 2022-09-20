/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает последнюю цифру этого числа
456 -> 6
*/

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number % 10;
Console.WriteLine($"Последняя цифра {ostatok}");
