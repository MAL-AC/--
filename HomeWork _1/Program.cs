// Задача 2:
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// Console.Write("input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int max = num1;
// int min = num2;

// if(num2 > num1)
// {
//     max = num2;
//     min = num1;
//     Console.WriteLine("max number: " + max);
//     Console.WriteLine("min number: " + min);
// }
// else 
// {
// if(num1 == num2)
// {
//     Console.WriteLine(+ num1 + " = " + num2);
// }
//         else 
//         {
//             Console.WriteLine("max number: " + max);
//             Console.WriteLine("min number: " + min);
//         }
// }


// Задача 4:
// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел

// Console.Write("input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > max)
// {
//     max = num2;
// }
// else 
// if(num2 == num1)
// {
//     Console.WriteLine("first number " + num1 + " = second number " + num2);
// }
// if(num3 > max)
// {
//     max = num3;
// }
// else 
// if(num3 == num2)
// {
//     Console.WriteLine("second number " + num2 + " = third number " + num3);
// }
// if (num1 == num3)
// {
//     Console.WriteLine("first number " + num1 + " = third number " + num3);
// }
// Console.WriteLine("max number: " + max);


// Задача 6.
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input a posible number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num %2 == 0)
// {
//     Console.WriteLine("The number is even");
// }
// else
// {
//     Console.WriteLine("The number is not even");
// }


// Задача 8. 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Input a posible number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = 1;

// while(current <= num)
// {
// if (current %2 == 0)
//     {
//         Console.Write(current + " ");
//     }
//      current++;
// }