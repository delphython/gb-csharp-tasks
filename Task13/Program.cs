//------------------------ Решение задачи 13 ------------------------------
// Напишите программу, которая принимает на вход два числа и проверяет, является
// ли одно число квадратом другого.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();

if (inputFirstLine != null && inputSecondLine != null)
{
    try 
    {
        //Парсим первое число
        int inputFirstNumber = int.Parse(inputFirstLine);
        //Парсим второе число
        int inputSecondNumber = int.Parse(inputSecondLine);
        
        // Проверяем условия и выводим данные в консоль
        Console.WriteLine("Число {0}" + (
            (inputFirstNumber / inputSecondNumber == inputSecondNumber) ? " является квадратом числа {1}" : " не является квадратом числа {1}"
        ), inputFirstNumber, inputSecondNumber);

        Console.WriteLine("Число {0}" + (
            (inputSecondNumber / inputFirstNumber == inputFirstNumber) ? " является квадратом числа {1}" : " не является квадратом числа {1}"
        ), inputSecondNumber, inputFirstNumber);

    }
    catch
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}