//------------------------ Решение задачи 6 ------------------------------
// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();
string? inputThirdLine = Console.ReadLine();

if (
    inputFirstLine != null && 
    inputSecondLine != null && 
    inputThirdLine != null
)
{
    try 
    {
        //Парсим числа
        int inputFirstNumber = int.Parse(inputFirstLine);
        int inputSecondNumber = int.Parse(inputSecondLine);
        int inputThirdNumber = int.Parse(inputThirdLine);

        // Выводим в консоль информацию по задаче
        Console.WriteLine(
            "Максимальным из чисел {0}, {1} и {2} является число {3}",
            inputFirstNumber,
            inputSecondNumber,
            inputThirdNumber,
            Math.Max(inputFirstNumber, Math.Max(inputSecondNumber, inputThirdNumber))
        );
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}