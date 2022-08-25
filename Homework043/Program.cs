//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindPoint(double k1, double b1, double k2, double b2) //находит координаты и возврщает массив
{
    double[] array = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    array[0] = Math.Round(x, 2);
    array[1] = Math.Round(y, 2);
    return array;
}

Console.Write("Введите коэффицинт К1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффицинт B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффицинт K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффицинт B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double[] coordinates = FindPoint(k1, b1, k2, b2);
if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают!");
else if(k1 == k2 ) Console.WriteLine("Прямые параллельны!");
else Console.WriteLine($"Координаты точки пересечения: x= {coordinates[0]}, y= {coordinates[1]}");