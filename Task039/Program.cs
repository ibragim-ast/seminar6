// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)

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

void ReversArray(int[] array)
{
    int length = array.Length / 2;
    int num = 0;

    for (int i = 0; i < length; i++)
    {
        num = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = num;
    }
}

int[] array = CreateArray(9, 0, 10);
PrintArray(array);
ReversArray(array);
PrintArray(array);
