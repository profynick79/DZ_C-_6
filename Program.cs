﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите несколько чисел от -100 до 100 через пробел: ");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count++;
//     }
// }
//  Console.WriteLine($"Количество положительных чисел: {count}");



// Задача 43. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");