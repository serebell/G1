﻿Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdNum = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(firstNum, Math.Max(secondNum, thirdNum));
Console.WriteLine($"{max}");