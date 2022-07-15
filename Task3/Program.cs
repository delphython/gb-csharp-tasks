//------------------------ Решение задачи 3 ------------------------------
// Напишите программу, которая на вход принимает одно число (N), а на 
// выходе показывает все целые числа в промежутке от -N до N.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        //Парсим число
        int inputNumber = int.Parse(inputLine);
        // Инициализируем переменные
        int startNumber = 1;
        string lineOutput = "0";

        // В цикле перебираем все числа согласно заданию
        while (startNumber <= inputNumber)
        {
            // Формируем строку для вывода
            lineOutput = startNumber*(-1) + ", " + lineOutput + ", " + startNumber;
            startNumber++;
        }
        
        // Выводим строку
        Console.WriteLine(lineOutput);
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
