//------------------------ Решение задачи 64 ------------------------------
// Задайте значение M. Напишите программу, которая выдает все натуральные
// числа от 1 до M
//------------------------------------------------------------------------

// Метод PrintNaturalNumbers, который выводит в консоль натруальные числа от 1 до M
void PrintNaturalNumbers(int numberTo, int numberFrom = 1)
{
    if (numberFrom > numberTo) return;
    Console.WriteLine(numberFrom);
    PrintNaturalNumbers(numberTo, numberFrom+1);
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
    Console.WriteLine($"Все натуральые числа от 1 до {m}:");
    PrintNaturalNumbers(m);

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
