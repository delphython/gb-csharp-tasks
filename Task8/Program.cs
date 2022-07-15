//------------------------ Решение задачи 8 ------------------------------
// Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
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
        int i = 0;
        int arrayLenght = inputNumber/2;
        int[] evenNumbersArray = new int[arrayLenght];
        
        // В цикле перебираем все все числа от 1 до N
        while (start <= inputNumber)
        {
            // Если число четное, сохраняем его в массив
            if (start%2 == 0)
            {
                evenNumbersArray[i] = start;
                i++;
            }
            start++;
        }

        // Формируемс строку для вывода
        string lineOutput = string.Join(", ", evenNumbersArray);

        // Выводим строку
        Console.WriteLine(lineOutput);
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
