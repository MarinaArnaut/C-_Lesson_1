﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Напишите число a");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите число b");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите число c");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if(a>b || a>c)
{
    max = a;
}

if(b>a || b>c)
{
    max = b;
}

if(c>a || c>b) 
{
    max = c;
}
Console.Write("Максимальное число = " +max!);
