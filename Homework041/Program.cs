// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    Console.WriteLine("Сколько чисел вы собираетесь ввести?");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] arrayNumber = new int[length];
    int count = 1;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {count} число");
        arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
    return arrayNumber;
}

void SumNumber(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
            index += 1;
    }
    if (index == 0)
    Console.WriteLine($"Вы ввели только отрицательные числа");
    else if (index == 1)
    Console.WriteLine($"Вы ввели {index} число больше 0");
    else if (index >= 2 && index < 5)
    Console.WriteLine($"Вы ввели {index} числа больше 0");
    else
    Console.WriteLine($"Вы ввели {index} чисел больше 0");
}

int[] array = CreateArray();
SumNumber(array);