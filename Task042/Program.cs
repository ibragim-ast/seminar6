// Напишите программу, которая будет преобразовывать десятичное число в двоичное

void ConvertNumToBinary()
{
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string bin = string.Empty;
int n = num;
while (n > 0)
{
    bin = $"{n % 2}" + bin;
    n /= 2;
}
Console.WriteLine(bin);
}

ConvertNumToBinary();

