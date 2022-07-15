//------------------------ Решение задачи 9 ------------------------------
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
//------------------------------------------------------------------------

// Объявляем метод getMaxDigitInNumberVersion1 
void getMaxDigitInNumberVersion1()
{
    // Генерируем случайное число и переводим его в строку
    string number = new Random().Next(10, 100).ToString();

    // Переводим все символы строки в список
    var digitsList = number.ToList();

    // Выводим в консоль информацию с максимальным значением
    // цифры среди элементов списка
    Console.WriteLine(
        "Максимальной цифрой числа {0} является цифра {1}",
        number,
        digitsList.Max()
    );
}

// Объявляем метод getMaxDigitInNumberVersion2 
void getMaxDigitInNumberVersion2()
{
    // Генерируем случайное число и переводим его в строку
    string number = new Random().Next(10, 100).ToString();

    // Объявляем список
    List<char> digitsList = new List<char>();

    // Добавляем элементы указанной коллекции в конец списка
    digitsList.AddRange(number);

    // Выводим в консоль информацию с максимальным значением
    // цифры среди элементов списка
    Console.WriteLine(
        "Максимальной цифрой числа {0} является цифра {1}",
        number,
        digitsList.Max()
    );
}

// Вызываем метод getMaxDigitInNumberVersion1 
getMaxDigitInNumberVersion1();

// Вызываем метод getMaxDigitInNumberVersion2 
getMaxDigitInNumberVersion2();
