//------------------------ Решение задачи 30 ------------------------------
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов
//------------------------------------------------------------------------

// Считываем данные с консоли
Console.Write("Введите длину массива: ");
string? inputLineOne = Console.ReadLine();
Console.Write("Введите диапазон значений массива от: ");
string? inputLineTwo = Console.ReadLine();
Console.Write("Введите диапазон значений массива до: ");
string? inputLineThree = Console.ReadLine();

if (inputLineOne != null && inputLineTwo != null && inputLineThree != null)
{
    try 
    {
        //Парсим длину массива
        int inputArrayLength = int.Parse(inputLineOne);
        //Парсим диапазон значений массива от
        int inputArrayFrom = int.Parse(inputLineTwo);
        //Парсим диапазон значений массива до
        int inputArrayTo = int.Parse(inputLineThree);
        
        // Инициализируем переменные
        int[] randNumberArray = new int[inputArrayLength];
        Random rand = new Random();
        
        // Заполняем массив числами 
        for (int i=0; i<inputArrayLength; i++)
        {
            randNumberArray[i]=rand.Next(inputArrayFrom, inputArrayTo+1);
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
