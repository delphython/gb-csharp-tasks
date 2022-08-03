//------------------------ Решение задачи 27 ------------------------------
// Напишите программу, которая выводит массив из N элементов, заполненный
// нулями и единицами в случайном порядке
//------------------------------------------------------------------------

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        //Парсим число
        int inputNumber = int.Parse(inputLine);
        // Инициализируем переменные
        int[] randNumberArray = new int[inputNumber];
        Random rand = new Random();
        
        // Заполняем массив числами от 0 до 1
        for (int i=0; i<inputNumber; i++)
        {
            randNumberArray[i]=rand.Next(0,2);
        }

        // Формируемс строку для вывода
        string lineOutput = string.Join(",", randNumberArray);

        // Выводим строку
        Console.WriteLine($"[{lineOutput}]");
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
