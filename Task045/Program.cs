// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] array = CreateArray(10, 0, 10);
PrintArray(array);
int[] newArray = CopyArray(array);
PrintArray(newArray);