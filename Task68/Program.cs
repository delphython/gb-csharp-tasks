//------------------------ Решение задачи 68 ------------------------------
// Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр.
//------------------------------------------------------------------------

// Метод SumNumberDigits, который считает сумму цифр числа
int SumNumberDigits(int number)
{
    if(number==0) return 0;
    return number % 10 + SumNumberDigits(number / 10); 
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m)
{
    m = 0;
    
    Console.WriteLine("Введите число m");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();
    
    if (inputFirstLine != null) m = int.Parse(inputFirstLine);
}

try 
{
    //Считываем данные с консоли
    int m;
    GetConsoleData(out m);

    // Выводим информацию в консоль
    Console.WriteLine($"Сумма цифр числа {m} = {SumNumberDigits(m)}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
