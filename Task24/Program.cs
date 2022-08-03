//------------------------ Решение задачи 24 ------------------------------
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
// чисел от 1 до А.
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
        double[] sumNumberArray = new double[inputNumber];
        
        // Заполняем массив числами от 1 до А
        for (int i=0 ; i<inputNumber ; i++)
        {
            sumNumberArray[i]=i+1;
        }

        // Считаем сумму всех чисел массива, переводим в строку и выводим ее
        Console.WriteLine($"Сумма всех чисел от 1 до {inputLine} равно {sumNumberArray.Sum().ToString()}");
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
