//------------------------ Решение задачи 46 ------------------------------
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем
// * Найдите площадь треугольника образованного пересечением 3 прямых
//------------------------------------------------------------------------

// Метод intersectionPoint, который определяет точку перечения двух прямых
double[] intersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] points = new double[2];
    if (k2!=k1)
    {
        points[0] = (b2-b1)/(k1-k2);
        points[1] = k1*(points[0])+b1;
    }
    return points;
}

// Метод triangleSpace, который считает площадь треугольника по формуле Герона
double triangleSpace(double[] ip1, double[] ip2, double[] ip3)
{
    // Находим стороны треугольника и его полупериметр
    double ab = Math.Sqrt(Math.Pow((ip1[0]-ip2[0]), 2) + Math.Pow((ip1[1]-ip2[1]), 2));
    double bc = Math.Sqrt(Math.Pow((ip2[0]-ip3[0]), 2) + Math.Pow((ip2[1]-ip3[1]), 2));
    double ca = Math.Sqrt(Math.Pow((ip1[0]-ip3[0]), 2) + Math.Pow((ip1[1]-ip3[1]), 2));
    double p = (1 / 2) * (ab + bc + ca);

    // Находим площадь треугольника
    double s = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
    
    return s;
}


// Считываем данные с консоли
Console.WriteLine("Введите коэффициенты k1 и b1 для уравнения y = k1 * x + b1");
Console.Write("k1 = ");
string? k1InString = Console.ReadLine();
Console.Write("b1 = ");
string? b1InString = Console.ReadLine();

Console.WriteLine("Введите коэффициенты k2 и b2 для уравнения y = k2 * x + b2");
Console.Write("k2 = ");
string? k2InString = Console.ReadLine();
Console.Write("b2 = ");
string? b2InString = Console.ReadLine();

Console.WriteLine("Введите коэффициенты k3 и b3 для уравнения y = k3 * x + b3");
Console.Write("k3 = ");
string? k3InString = Console.ReadLine();
Console.Write("b3 = ");
string? b3InString = Console.ReadLine();

if (
    k1InString != null &&
    b1InString != null &&
    k2InString != null &&
    b2InString != null &&
    k3InString != null &&
    b3InString != null
)
{
    try 
    {
        //Парсим входные число
        double k1 = Convert.ToDouble(k1InString);
        double b1 = Convert.ToDouble(b1InString);
        double k2 = Convert.ToDouble(k2InString);
        double b2 = Convert.ToDouble(b2InString);
        double k3 = Convert.ToDouble(k3InString);
        double b3 = Convert.ToDouble(b3InString);

        double[] interPoints1 = intersectionPoint(k1, b1, k2, b2);
        double[] interPoints2 = intersectionPoint(k2, b2, k3, b3);
        double[] interPoints3 = intersectionPoint(k1, b1, k3, b3);
        
        // Проверяем условия и выводим данные в консоль
        Console.WriteLine($"Прямые y={k1}*x+{b1} и y={k2}*x+{b2}" + (
            (interPoints1.Any()) ? $" пересекаются в точке {interPoints1[0]}, {interPoints1[1]}" : " не пересекаются"
        ));
        Console.WriteLine($"Прямые y={k2}*x+{b2} и y={k3}*x+{b3}" + (
            (interPoints2.Any()) ? $" пересекаются в точке {interPoints2[0]}, {interPoints2[1]}" : " не пересекаются"
        ));
        Console.WriteLine($"Прямые y={k1}*x+{b1} и y={k3}*x+{b3}" + (
            (interPoints3.Any()) ? $" пересекаются в точке {interPoints3[0]}, {interPoints3[1]}" : " не пересекаются"
        ));

        // Считаем площадь треугольника и выводим значение на консоль

        // Если все три линии пересеклись
        if (interPoints1.Any() && interPoints2.Any() && interPoints3.Any())
            {
                double s = triangleSpace(interPoints1, interPoints2, interPoints3);
                if (s < 0)
                    Console.WriteLine("Это вряд ли треугольник (как минимум одна из сторон)");
                else
                    Console.WriteLine($"Площадь треугольника равна {s}");
            }
        else
            Console.WriteLine("Площадь треугольника не посчитать, т.к. хотя две прямых не пересеклись");

    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}