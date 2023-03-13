/*
int[,,] CreateRandom2dArray()
{
    Console.Write("input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a numbers of col: ");
    int col = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int [rows, columns, col];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            for(int k = 0; k < col; k++)
                array[i,j,k] = new Random(). Next(minValue, maxValue + 1);

    return array;
}
void Show2dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            Console.Write(array[i, j, k] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

// Console.WriteLine($"Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");
/*
Console.Write("input a numbers of rows: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input a numbers of columns: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("input a numbers of deep: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());



int[,,] array3D = new int[x, y, z];

void ShowArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i}, {j}, {k}); ");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(minValue, maxValue);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(minValue, maxValue);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

CreateArray(array3D);
ShowArray(array3D);
*/

Console.Write("input the size of the sides for the square array: ");
int size = Convert.ToInt32(Console.ReadLine());


int[,] sqareArray = new int[size, size];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareArray.GetLength(0) * sqareArray.GetLength(1))
{
    sqareArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(sqareArray);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}