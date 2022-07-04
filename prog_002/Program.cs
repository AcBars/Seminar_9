/*
Задача 69:** Напишите программу, которая на вход принимает два числа A и B, и возводит число
А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)

A = 2; B = 3 -> 8
*/

using System;
using static System.Console;

Clear();
WriteLine("Введите N: ");
int n = Convert.ToInt32(ReadLine());
Clear();
WriteLine("Введите M: ");
int m = Convert.ToInt32(ReadLine());
WriteLine(DegreeNumbers(n, m));

int DegreeNumbers(int a, int b)
{
    if (b > 0)
    {
        return a * DegreeNumbers(a, --b);
    }
    else return 1;
}
