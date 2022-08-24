//------------------------ Решение задачи 67 ------------------------------
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
//------------------------------------------------------------------------

// Метод SumNaturalNumbers, который считает сумму натруальных чисел от M до N
int SumNaturalNumbers(int numberFrom, int numberTo)
{
    if (numberTo == numberFrom)
        return numberFrom;
    else
        return numberTo + SumNaturalNumbers(numberFrom, numberTo-1); 
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
    if (m > n)
        Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumNaturalNumbers(n, m)}");
    else
        Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumNaturalNumbers(m, n)}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
