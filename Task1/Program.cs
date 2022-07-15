//------------------------ Решение задачи 1 ------------------------------
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
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

        // Проверяем условия и выводим соответствующую информацию
        if (inputSecondNumber == Math.Sqrt(inputFirstNumber))
        {
            Console.WriteLine(
                "The first number {0} is the square of the second number {1}",
                inputFirstNumber,
                inputSecondNumber
            );
        }
        else
        {
            Console.WriteLine(
                "The first number {0} is not the square of the second number {1}",
                inputFirstNumber,
                inputSecondNumber
            );
        }
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
