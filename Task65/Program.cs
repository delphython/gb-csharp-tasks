//------------------------ Решение задачи 65 ------------------------------
// Задайте значение M. Напишите программу, которая выдает все натуральные
// числа от M до 1
//------------------------------------------------------------------------

// Метод PrintNaturalNumbers, который выводит в консоль натруальные числа от M до 1
void PrintNaturalNumbers(int numberFrom, int numberTo = 1)
{
    if (numberFrom < numberTo) return;
    Console.WriteLine(numberFrom);
    PrintNaturalNumbers(numberFrom-1, numberTo);
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m)
{
    m = 0;
    
    Console.WriteLine("Введите натуральное число m");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();

    if (inputFirstLine != null)
    {
        m = int.Parse(inputFirstLine);
    }
}

try 
{
    //Считываем данные с консоли
    int m;
    GetConsoleData(out m);

    // Выводим информацию в консоль
    Console.WriteLine($"Все натуральые числа от {m} до 1:");
    PrintNaturalNumbers(m);

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
