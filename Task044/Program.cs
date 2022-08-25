// Не используя рекурсию, вывведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fibonacci(int num)
{
    int fnum1 = 0;
    int fnum2 = 1;
    int temp;

    Console.Write($"{fnum1} ");
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{fnum2} ");
        temp = fnum2;
        fnum2 = fnum2 + fnum1;
        fnum1 = temp;
    }
}

Fibonacci(25);