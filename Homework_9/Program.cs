// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
Console.Write("input a natural number: ");
int num = Convert.ToInt32(Console.ReadLine());

int temp = 1;

void ShowNums (int temp, int num)
{
    if(num > temp) ShowNums(temp+1, num);
    Console.Write(temp + " ");
}

if(num > 0)
ShowNums(temp, num);
else Console.WriteLine("Incorrectly, input a natural number");
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
Console.Write("input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int ShowNums(int m, int n)
{
    int sum = n;
    if(n > m) sum = m + ShowNums(n, m + 1);
    if(n < m) sum = m + ShowNums(n, m - 1);
    else return sum;
    return sum;
}

if (m > 0 && n  > 0)
{
int sum = ShowNums(m, n);
Console.WriteLine($"Sum numbers from {m} to {n} is {sum}");
}
else Console.WriteLine("Incorrectly, input natural numbers");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
Console.Write("input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
if (m >= 0 && n >= 0)
{
    int sum = Ack(m, n);
    Console.WriteLine($"Ackerman function numbers {m} and {n} is {sum}");
}
else Console.WriteLine("Incorrectly, input numbers from zero");
*/