/*
**Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его
цифр.
453 -> 12
45 -> 9
*/

using System;
using static System.Console;

Clear();
WriteLine("Введите N: ");
int n = Convert.ToInt32(ReadLine());
WriteLine(SummNumbers(n));

int SummNumbers(int a)
{

    if (a > 0) return ((a % 10) + (SummNumbers(a / 10)));
    else return 0;
}
