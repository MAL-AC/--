﻿// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num +" ");
}

ShowNums(5);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    if(num / 10 != 0) return SumOfDigits(num / 10) + Math.Abs(num % 10);
    return Math.Abs(num);
}

Console.WriteLine(SumOfDigits(1234));
*/

// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

/*
void ShowNums(int n, int m)
{
    if(n > m) ShowNums(n, m + 1);
    if(n < m) ShowNums(n, m - 1);
    Console.Write(m + " ");
}

ShowNums(8, 5);
*/

// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B.

/*
double PowerOfNum (double num, int pow)
{
    if (pow ==0) return 1;
    else
    {
        if(pow > 0)
            return PowerOfNum(num, pow - 1) * num;
        else
            return PowerOfNum(num, pow + 1) / num;
    }
}

Console.WriteLine(PowerOfNum(2, 4));
*/