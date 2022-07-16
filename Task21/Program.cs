//------------------------ Решение задачи 21 ------------------------------
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//------------------------------------------------------------------------

// Объявляем метод createPalindroms, который генерирует все четырехзначные палиндромы
List<int> createPalindroms()
{
    List<int> palindroms = new List<int>();

    for (int i = 1000; i < 10000; i++)
    {
        string digit = i.ToString();

        int digit1 = int.Parse(digit[0].ToString());
        int digit2 = int.Parse(digit[1].ToString());
        int digit3 = int.Parse(digit[2].ToString());
        int digit4 = int.Parse(digit[3].ToString());
        
        if (digit1 == digit4 & digit3 == digit2)
        {
            palindroms.Add(i);
        }        
    }

    return palindroms;
}

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    try 
    {
        // Убираем из пятизначного числа третье число
        string fourDigitsNumber = inputLine.Remove(inputLine.Length - 3, 1);

        // Console.WriteLine(fourDigitsNumber);
        
        //Парсим число
        int inputNumber = int.Parse(fourDigitsNumber);
        
        // Вызываем метод createPalindroms
        List<int> fourDigitsPalindroms = createPalindroms();

        // Проверяем, есть ли четырехзначное число в списке и, если есть выводим сообщение
        Console.WriteLine("Число {0}" + (
            (fourDigitsPalindroms.Contains(inputNumber)) ? " - палиндром" : " не палиндром"
        ), inputLine);
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
