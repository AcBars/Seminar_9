/*
Задайте значение N и M. Напишите программу, которая выдает все натуральные числа в промежутке
от 1 до N
*/

using System;
using static System.Console;

Clear();

WriteLine("Введите N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Введите стартовое число: ");
int m = Convert.ToInt32(ReadLine());
OutputBeforeN(n, m);

void OutputBeforeN(int a, int start)
{
    if (start <= a)
    {
        Write($"{start} ");
        start++;
        OutputBeforeN(a, start);
    }
    else return;
}

