//------------------------ Решение задачи 22 ------------------------------
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве
//------------------------------------------------------------------------

using System.Text.RegularExpressions;

// Объявляем метод readPoints, который считывает данные и возвращает массив
int[,] readPoints()
{
    // Считываем данные с консоли
    Console.Write("Ведите координаты точек А и В в формате A(3,6,4); B(2,1,4): ");
    string? inputLine = Console.ReadLine();
    
    if (inputLine != null)
    {
        try 
        {
            // Инициализируем регулярные выражения для поиска
            string pattern1 = @"A\((-?\d+),(-?\d+),(-?\d+)\);";
            string pattern2 = @"B\((-?\d+),(-?\d+),(-?\d+)\)";

            // Выполняем поиск по регулярным выражениям
            Match m1 = Regex.Match(inputLine, pattern1);
            Match m2 = Regex.Match(inputLine, pattern2);

            if (m1.Success && m2.Success)
            {
                // Если поиск удачный, то парсим найденные координаты
                int coordX1 = int.Parse(m1.Groups[1].Value);
                int coordY1 = int.Parse(m1.Groups[2].Value);
                int coordZ1 = int.Parse(m1.Groups[3].Value);
                int coordX2 = int.Parse(m2.Groups[1].Value);
                int coordY2 = int.Parse(m2.Groups[2].Value);
                int coordZ2 = int.Parse(m2.Groups[3].Value);

                // Объявляем массив
                int[,] arrayOut = new int [2, 3];

                // Заполняем массив координатами
                arrayOut[0, 0] = coordX1;
                arrayOut[0, 1] = coordY1;
                arrayOut[0, 2] = coordZ1;
                arrayOut[1, 0] = coordX2;
                arrayOut[1, 1] = coordY2;
                arrayOut[1, 2] = coordZ2;

                return arrayOut;
            }
            else
            {
                // Если хотя бы одна координата не определена, то возвращаем пустой массив
                return new int [1, 1];
            }
        }
        catch (Exception e)
        {
            // Выводим сообщение об ошибке и возвращаем пустой массив
            Console.WriteLine($"Что-то в методе readPoints не так: {e}");
            return new int [1, 1];
        }
    }
    else
    {
        // Возвращаем пустой массив
        return new int [1, 1];
    }
}

// Объявляем метод printDistance, который расчитывает расстояние и выводит его в консоль
void printDistance(int[,] array)
{
    try 
    {
        // Расчитываем расстояние
        double distance = Math.Sqrt(Math.Pow(array[1, 0] - array[0, 0], 2) + Math.Pow(array[1, 1] - array[0, 1], 2) + Math.Pow(array[1, 2] - array[0, 2], 2));
        
        // Выводим результат работы программы
        Console.WriteLine($"Расстояние между точками равно {distance.ToString("0.00")}");
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то в методе calculateDistance не так: {e}");
    }
}

// Вызываем метод readPoints
int[,] arrayOfPoints = readPoints();

// Проверяем, что метод readPoints вернул не пустой массив
if (arrayOfPoints.Length > 1)
{
    // Вызываем метод printDistance
    printDistance(arrayOfPoints);
}
else
{
    // Сообщаем, что координаты не определены
    Console.WriteLine("Координаты не определены.");
}
