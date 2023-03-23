int[] CopyArray(int[] array)
{
    int[] result = new int[array.LongLength];
    for(int i = 0; i < array.Length; i++)
        result [i] = array [i];
    return result;
}

int[] CreateRandomArray(int size , int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i <size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

ShowArray(CopyArray(newArray));
