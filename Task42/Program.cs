//------------------------ Решение задачи 42 ------------------------------
// Напишите программу, которая будет преобразовывать десятичное число в 
// двоичное.
//------------------------------------------------------------------------

// Объявляем метод convertDecToBinHard, который преобразует десятичное число в двоичное
string convertDecToBinHard(int dec)
{
    string bin = "";
    
    while (dec > 0)
    {
        bin = ((dec % 2 == 0) ? "0" : "1") + bin;
        dec /= 2;
    }
    
    return bin;
}

// Объявляем метод convertDecToBinHarder, который преобразует десятичное число в двоичное
string convertDecToBinHarder(int dec)
{
    var stack = new Stack<int>();
    
    while (dec > 0)
    {
        stack.Push(dec % 2);
        dec /= 2;
    }
    
    return String.Join("", stack);
}

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {     
        // Парсим число
        int inputNumber = int.Parse(inputLine);
        
        // легкий способ
        string decResultOne = string.Join("", Convert.ToString(inputNumber, 2));

        // тяжелый способ
        string decResultTwo = convertDecToBinHard(inputNumber);

        // более тяжелый способ
        string decResultThree = convertDecToBinHarder(inputNumber);

        // Выводим результаты
        Console.WriteLine($"Легкий способ: десятичное число {inputNumber} в двоичном виде = {decResultOne}");
        Console.WriteLine($"Тяжелый способ: десятичное число {inputNumber} в двоичном виде = {decResultTwo}");
        Console.WriteLine($"Более тяжелый способ: десятичное число {inputNumber} в двоичном виде = {decResultThree}");
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
