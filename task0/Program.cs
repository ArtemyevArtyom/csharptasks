﻿/*
Напишите программу, которая на вход принимает число и выдаёт его квадрат
Например:
4 -> 16
-3 -> 9
*/
Console.WriteLine("Введите значение: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber * userNumber;
Console.WriteLine($"Квадрат числа {userNumber} равен {result}");