// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины

bool Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    return true;
    else
    return false;
}

System.Console.WriteLine(Triangle(1,2,3));