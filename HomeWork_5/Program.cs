// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int HaveEvenNumber(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i]%2 == 0)
//         sum= sum+1;

//     return sum;
// } 

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     int minValue = 100; 
//     int maxValue = 999;
//     for(int i = 0; i <size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//         return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);

// int sum = HaveEvenNumber(newArray);

// Console.WriteLine($"The array has even numbers is {sum}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int SumOfOddPositions(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(i %2 != 0)
//         sum= sum + array[i];

//     return sum;
// } 

// int[] CreateRandomArray(int size , int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i <size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//         return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int sum = SumOfOddPositions(newArray);

// Console.WriteLine($"Sum of odd array positions is {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//                                     Вариант 1. Целые числа

// int MaxArray(int[] array)
// {
//     int max = array[0];
//     for(int i = 1; i < array.Length; i++)
//         if(array[i] > max)
//         max = array[i];

//     return max;
// } 

// int MinArray(int[] array)
// {
//     int min = array[0];
//     for(int i = 1; i < array.Length; i++)
//         if(array[i] < min)
//             min = array[i];

//     return min;
// } 

// int[] CreateRandomArray(int size , int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i <size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//         return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// int MaxiArray = MaxArray(newArray);
// int MiniArray = MinArray(newArray);
// int diff = MaxiArray - MiniArray;

// Console.WriteLine($"Min array is {MiniArray}, max array is {MaxiArray} ");
// Console.WriteLine($"The difference between the max and min arrays is {diff}");


//                         Вариант 2. Вещественные числа

// double MaxArray(double[] array)
// {
//     double max = array[0];
//     for(int i = 1; i < array.Length; i++)
//         if(array[i] > max)
//         max = array[i];

//     return max;
// } 

// double MinArray(double[] array)
// {
//     double min = array[0];
//     for(int i = 1; i < array.Length; i++)
//         if(array[i] < min)
//             min = array[i];

//     return min;
// } 

// double[] CreateRandomArray(int size , int minValue, int maxValue)
// {
//     double[] array = new double[size];

//     for(int i = 0; i <size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//         return array;
// }

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
    
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] newArray = CreateRandomArray(size, min, max);
// ShowArray(newArray);

// double MaxiArray = MaxArray(newArray);
// double MiniArray = MinArray(newArray);
// double diff = MaxiArray - MiniArray;

// Console.WriteLine($"Min array is {MiniArray}, max array is {MaxiArray} ");
// Console.WriteLine($"The difference between the max and min arrays is {diff}");



