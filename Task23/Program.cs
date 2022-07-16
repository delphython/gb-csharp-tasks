//------------------------ Решение задачи 23 ------------------------------
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N
//------------------------------------------------------------------------

// Объявляем метод createTableString, который формирует из элементов массива строки для таблицы
// исходя из количества символов в максимальном числе массива
string createTableString(double[] array, int NumberLength)
{
    
    string lineOutput = "";

    foreach (var number in array)
    {
        int spacesCount = NumberLength - number.ToString("0").Length;
        var spaces = new string(' ', spacesCount);
        lineOutput = lineOutput + "|" + spaces + " " + (number.ToString("0"));
    }
    
    return lineOutput + "|";
}

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
        double[] numberArray = new double[inputNumber];
        double[] cubeNumberArray = new double[inputNumber];
        
        // В цикле перебираем все все числа от 1 до N
        while (start <= inputNumber)
        {
            // Возводим число в куб и сохраняем в массив
            cubeNumberArray[start-1] = Math.Pow(start, 3);
            numberArray[start-1] = start;
            start++;
        }

        // Считаем количество символов в максимальном числе массива
        int maxNumberLength = (cubeNumberArray.Max() + 1).ToString("0").Length;

        // Вызываем метод createTableString
        string lineOneOutput = createTableString(numberArray, maxNumberLength);
        string lineTwoOutput = createTableString(cubeNumberArray, maxNumberLength);

        // Формируем линию между строками
        var tableLine = new string('-', lineOneOutput.Length);

        // Выводим таблицу
        Console.WriteLine(tableLine);
        Console.WriteLine(lineOneOutput);
        Console.WriteLine(tableLine);
        Console.WriteLine(lineTwoOutput);
        Console.WriteLine(tableLine);
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
