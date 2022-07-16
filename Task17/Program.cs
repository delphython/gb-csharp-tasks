//------------------------ Решение задачи 17 ------------------------------
// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой
// находится эта точка.
//------------------------------------------------------------------------

using System.Text.RegularExpressions;

// Объявляем метод readPoints, который считывает данные и возвращает массив
int[,] readPoints()
{
    // Считываем данные с консоли
    string? inputLine = Console.ReadLine();
    
    if (inputLine != null)
    {
        try 
        {
            // Инициализируем регулярные выражения для поиска
            string pattern1 = @"x=(-?\d+);";
            string pattern2 = @"y=(-?\d+)";

            // Выполняем поиск по регулярным выражениям
            Match m1 = Regex.Match(inputLine, pattern1);
            Match m2 = Regex.Match(inputLine, pattern2);

            if (m1.Success && m2.Success)
            {
                // Если поиск удачный, то парсим найденные координаты
                int coordX = int.Parse(m1.Groups[1].Value);
                int coordY = int.Parse(m2.Groups[1].Value);

                // Объявляем массив
                int[,] arrayOut = new int [1, 2];

                // Заполняем массив координатами
                arrayOut[0, 0] = coordX;
                arrayOut[0, 1] = coordY;

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

// Объявляем метод printQuarterNumber, который выводит номер четверти
void printQuarterNumber(int[,] array)
{
    try 
    {
        if (array[0, 0] > 0)
            {
                if (array[0, 1] > 0)
                    Console.WriteLine("I четверть");
                else
                    Console.WriteLine("IV четверть");
            }
        else
            {
                if (array[0, 1] > 0)
                    Console.WriteLine("II четверть");
                else
                    Console.WriteLine("III четверть");
            }
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то в методе printQuarterNumber не так: {e}");
    }
}

// Вызываем метод readPoints
int[,] arrayOfPoints = readPoints();

// Проверяем, что метод readPoints вернул не пустой массив
if (arrayOfPoints.Length > 1)
{
    // Выводим результат работы программы
    printQuarterNumber(arrayOfPoints);
}
else
{
    // Сообщаем, что координаты не определены
    Console.WriteLine("Координаты не определены.");
}
