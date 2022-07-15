//------------------------ Решение задачи 5 ------------------------------
// Напишите программу, которая на вход принимает два числа и выдаёт, какое
// число большее, а какое меньшее.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();

if (inputFirstLine != null && inputSecondLine != null)
{
    try 
    {
        //Парсим числа
        int inputFirstNumber = int.Parse(inputFirstLine);
        int inputSecondNumber = int.Parse(inputSecondLine);
        
        // Выводим в консоль информацию по задаче
        Console.WriteLine(
            "Максимальным из чисел {0} и {1} является число {2}",
            inputFirstNumber,
            inputSecondNumber,
            Math.Max(inputFirstNumber, inputSecondNumber)
        );
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
