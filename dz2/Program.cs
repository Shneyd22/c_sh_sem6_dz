// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b первой прямой");
double b1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение b второй прямой");
double b2 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение k первой прямой");
double k1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите значение k второй прямой");
double k2 = Convert.ToDouble (Console.ReadLine());
if (CheckLines (b1, b2, k1, k2))
CrossPoint (b1, b2, k1, k2);




void CrossPoint (double b1, double b2, double k1, double k2)
{
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine ($"Координаты точки пересечения прямых ({x}, {y})");
}



bool CheckLines (double b1, double b2, double k1, double k2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        Console.WriteLine ("Прямые совпадают");
        else 
        Console.WriteLine ("Прямые парралельны");
        return false;
    }
    else
        return true;
}