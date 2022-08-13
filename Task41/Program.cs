//------------------------ Решение задачи 41 ------------------------------
// Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
//------------------------------------------------------------------------

// Метод reverseArray, который переворачивает одномерный массив
bool isExistTriangle(double a, double b, double c)
{
    if (a + b <= c || a + c <= b || b + c <= a) return false;
    return true;
}


// Считываем данные с консоли
string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();
string? inputThirdLine = Console.ReadLine();

if (inputFirstLine != null && inputSecondLine != null && inputThirdLine != null)
{
    try 
    {
        //Парсим входные число
        double a = Convert.ToDouble(inputFirstLine);
        double b = Convert.ToDouble(inputSecondLine);
        double c = Convert.ToDouble(inputThirdLine);
        
        // Проверяем условия и выводим данные в консоль
        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c}" + (
            (isExistTriangle(a, b, c)) ? " существует" : " не существует"
        ));

    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}