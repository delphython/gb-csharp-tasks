//------------------------ Решение задачи 66 ------------------------------
// Задайте значение M. Напишите программу, которая выдает все натуральные
// числа от M до N 
//------------------------------------------------------------------------

// Метод PrintNaturalNumbers, который выводит в консоль натруальные числа от M до N
void PrintNaturalNumbers(int numberFrom, int numberTo)
{
    if (numberFrom > numberTo) return;
    Console.WriteLine(Math.Abs(numberFrom));
    PrintNaturalNumbers(numberFrom+1, numberTo);
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m, out int n)
{
    m = 0;
    n = 0;
    
    Console.WriteLine("Введите натуральные числа m и n");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();
    Console.Write("n = ");
    string? inputSecondLine = Console.ReadLine();

    if (inputFirstLine != null && inputSecondLine != null)
    {
        m = int.Parse(inputFirstLine);
        n = int.Parse(inputSecondLine);
    }
}

try 
{
    //Считываем данные с консоли
    int m;
    int n;
    GetConsoleData(out m, out n);

    // Выводим информацию в консоль
    Console.WriteLine($"Все натуральые числа от {m} до {n}:");
    if (m < n) PrintNaturalNumbers(m, n);
    else PrintNaturalNumbers(-m, -n);

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
