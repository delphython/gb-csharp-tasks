//------------------------ Решение задачи 70 ------------------------------
// Напишите программу, которая на вход принимает два числа А и В и возводит
// число А в целую степень В с помощью рекурсии
//------------------------------------------------------------------------

// Метод PowNumberReq, который возводит число А в степень В с помощью рекурсии
int PowNumberReq(int a, int b)
{
    if (b == 1) return a;
    return a * PowNumberReq(a, b-1); 
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int a, out int b)
{
    a = 0;
    b = 0;
    
    Console.WriteLine("Введите числа a и b");
    Console.Write("a = ");
    string? inputFirstLine = Console.ReadLine();
    Console.Write("b = ");
    string? inputSecondLine = Console.ReadLine();

    if (inputFirstLine != null && inputSecondLine != null)
    {
        a = int.Parse(inputFirstLine);
        b = int.Parse(inputSecondLine);
    }
}

try 
{
    //Считываем данные с консоли
    int a;
    int b;
    GetConsoleData(out a, out b);

    // Выводим информацию в консоль
    Console.WriteLine($"Результат возведения числа {a} в степень {b} = {PowNumberReq(a, b)}");
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
