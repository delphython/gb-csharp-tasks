//------------------------ Решение задачи 18 ------------------------------
// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).
//------------------------------------------------------------------------

// Объявляем метод printRange, который выводит информацию
void printRange(int number)
{
    switch (number)
    {
        case 1:
            Console.WriteLine("Диапазон: x > 0, y > 0");
            break;
        case 2:
            Console.WriteLine("Диапазон: x < 0, y > 0");
            break;
        case 3:
            Console.WriteLine("Диапазон: x < 0, y < 0");
            break;
        case 4:
            Console.WriteLine("Диапазон: x > 0, y < 0");
            break;
        default:
            Console.WriteLine("У координатной плоскости нет такой четверти :)");
            break;
    }
}

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        //Парсим число
        int inputNumber = int.Parse(inputLine);

        // Вызываем метод printRange
        printRange(inputNumber);
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}