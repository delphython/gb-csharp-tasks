//------------------------ Решение задачи 28 ------------------------------
// Написать калькулятор с операциями +, -, /, * и возведение в степень
//------------------------------------------------------------------------

// Инициализируем переменные
string[] nums = new string[2];

// Считываем данные с консоли
for (int i = 0; i < 2; i++)
{
    Console.Write("Введите {0}-е число: ", i + 1);
    nums[i] = Console.ReadLine();
}
Console.Write(@"Введите математическое действие, где
+ сложение,
- вычитание,
* умножение,
/ деление,
^ возведение в степень: ");
string? mathOperation = Console.ReadLine();

if (nums[0] != null && nums[1] != null && mathOperation != null)
{
    try 
    {
        // Парсим первое число
        double inputFirstNumber = double.Parse(nums[0]);
        // Парсим второе число
        double inputSecondNumber = double.Parse(nums[1]);
        // Конвертируем математическое действие
        char oper = Convert.ToChar(mathOperation);
        
        //Парсим математическое действие и выполняем его
        switch (oper)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", inputFirstNumber, inputSecondNumber, inputFirstNumber + inputSecondNumber);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", inputFirstNumber, inputSecondNumber, inputFirstNumber - inputSecondNumber);
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", inputFirstNumber, inputSecondNumber, inputFirstNumber * inputSecondNumber);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", inputFirstNumber, inputSecondNumber, inputFirstNumber / inputSecondNumber);
                    break;
                case '^':
                    Console.WriteLine("{0} ^ {1} = {2}", inputFirstNumber, inputSecondNumber, Math.Pow(inputFirstNumber, inputSecondNumber));
                    break;
                default: Console.WriteLine("Введен неизвестный символ математической операции");
                    break;
            }
    }
    catch (Exception e)
    {
        // Выводим сообщение об ошибке
        Console.WriteLine($"Что-то здесь не так: {e}");
    }
}
