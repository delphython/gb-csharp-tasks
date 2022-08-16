//------------------------ Решение задачи 45 ------------------------------
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
//------------------------------------------------------------------------

using System;
using System.Text;

// Считываем данные с консоли
Console.WriteLine("Введите количество нажатий");
string? inputLine = Console.ReadLine();
Console.WriteLine("Теперь вводите любое целое число и завершайте ввод нажатием кллавиши Enter");

if (inputLine != null)
{
    try 
    {     
        // Парсим число
        int inputNumber = int.Parse(inputLine);

        // Инициализация переменных
        int positiveAmount = 0;
        StringBuilder sb = new StringBuilder();
        ConsoleKeyInfo key;
        
        while (inputNumber > 0)
        {
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                char pressedChar = key.KeyChar;

                // Проверка, что вводится цифра;
                // есть возможность удалить введеный символ;
                // знак "минус" можно ввести только в начале и нигде БОЛЬШЕ!!!
                if (
                    Char.IsDigit(pressedChar) ||
                    key.Key == ConsoleKey.Backspace ||
                    (key.Key == ConsoleKey.OemMinus && sb.Length == 0)
                )
                {
                    // Выводим на консоль введенный символ и сохраняем его в буфер
                    Console.Write(pressedChar);
                    sb.Append(pressedChar);
                }
            }
            // Перевод строки после нажатия Enter
            Console.WriteLine();

            // Если введенное число больше 0, то увеличиваем счетчик положительных чисел
            if (int.Parse(sb.ToString()) > 0) positiveAmount++;
            
            // Очищаем буфер
            sb.Clear();

            // Уменьшаем счетчик нажатий
            inputNumber--;
        }       

        // Выводим результаты
        Console.WriteLine($"Количество введенных чисел больше нуля = {positiveAmount}");
    }       
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
