//------------------------ Решение задачи 20 ------------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
//  квадратов чисел от 1 до N.
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
        int start = 1;
        double[] squareNumberArray = new double[inputNumber];
        
        // В цикле перебираем все все числа от 1 до N
        while (start <= inputNumber)
        {
            // Возводим число в квадрат и сохраняем в массив
            squareNumberArray[start-1] = Math.Pow(start, 2);
            start++;
        }

        // Формируемс строку для вывода
        string lineOutput = string.Join(", ", squareNumberArray);

        // Выводим строку
        Console.WriteLine(lineOutput);
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
