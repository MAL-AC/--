// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double [,] CreateRandom2dArray()
{
    Console.Write("input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round((new Random().NextDouble() * (maxValue - minValue) + minValue), 1);
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random(). Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NumberOfArray(int[,] array)
{
Console.Write("input the index of row: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("input the index of column: ");
int j = Convert.ToInt32(Console.ReadLine());

    if(i < array.GetLength(0) && j < array.GetLength(1))
    {
        int result = array[i, j];
        Console.WriteLine($"Your number is {result}");
    }
    else
        Console.WriteLine($"No correct");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
NumberOfArray(newArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
void ArithmeticMeanOfColumn(int[,] array) 
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
                double sum = 0;
                for(int i = 0; i < array.GetLength(0); i++)
                sum+= (double)array [i,j]/array.GetLength(0);
                sum = Math.Round(sum, 2, MidpointRounding.AwayFromZero);
                Console.Write(sum + " ");
    }
}

int[,] CreateRandom2dArray() {
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
ArithmeticMeanOfColumn(newArray);
*/



