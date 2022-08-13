//------------------------ Решение задачи 44 ------------------------------
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
//------------------------------------------------------------------------

// Объявляем метод fib, который считает числа Фибоначчи
List<int> fibonachiList(int number)
{
    List<int> fibList = new List<int> {0, 1};
    for (int i = 0; i < number; i++)
    {
        int num = fibList.Skip(i).Sum();
        fibList.Add(num);
    }
    
    return fibList;
}

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {     
        // Парсим число
        int inputNumber = int.Parse(inputLine);
        
        // считаем фисла Фибоначчи
        List<int> fibList = fibonachiList(inputNumber);

        // Формируем строки для вывода массивов
        string lineOutputOne = string.Join(",", fibList);

        // Выводим результаты
        Console.WriteLine($"Первые {inputNumber} чисел Фибоначчи: {lineOutputOne}");
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
