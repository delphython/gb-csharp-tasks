//------------------------ Решение задачи 10 ------------------------------
// Напишите программу, которая выводит случайное трёхзначное число и удаляет
// вторую цифру этого числа.
//------------------------------------------------------------------------

// Объявляем метод removeSecondDigitVersion1 
void removeSecondDigitVersion1()
{
    // Генерируем случайное число и переводим его в строку
    string number = new Random().Next(100, 1000).ToString();

    // Выводим в консоль информацию. 
    // Берем символы из строки по их индексу
    Console.WriteLine(
        "Удалили из числа {0} вторую цифру и получили число {1}",
        number, $"{number[0]}{number[2]}"
    );
}

// Объявляем метод removeSecondDigitVersion2 
void removeSecondDigitVersion2()
{
    // Генерируем случайное число и переводим его в строку
    string number = new Random().Next(100, 1000).ToString();

    // Выводим в консоль информацию
    // Удаляем из строки символ по его индексу
    Console.WriteLine(
        "Удалили из числа {0} вторую цифру и получили число {1}",
        number, $"{number.Remove(number.Length - 2, 1)}"
    );
}

// Объявляем метод removeSecondDigitVersion3 
void removeSecondDigitVersion3()
{
    // Генерируем случайное число
    int number = new Random().Next(100, 1000);
    
    // Расчитываем число без второй цифры
    int result = (number / 100) * 10 + (number % 10);

    // Выводим в консоль информацию
    Console.WriteLine(
        "Удалили из числа {0} вторую цифру и получили число {1}",
        number, result);
}
// Вызываем метод removeSecondDigitVersion1 
removeSecondDigitVersion1();

// Вызываем метод removeSecondDigitVersion2 
removeSecondDigitVersion2();

// Вызываем метод removeSecondDigitVersion3 
removeSecondDigitVersion3();
