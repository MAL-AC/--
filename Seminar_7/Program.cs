// Задача 1.
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("input a numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("input a numbers of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int [rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random(). Next(minValue, maxValue + 1);

//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aij = i + j. Выведите полученный массив на экран.

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

