//------------------------ Решение задачи 56 ------------------------------
// Задайте двумерный массив. Напишите программу, которая заменяет строки на
// столбцы. В случае, если это не возможно, программа должна вывести
// сообщение для пользователя
//------------------------------------------------------------------------

// Андрей, обращаюсь к Вам здесь, чтобы предупредить, что я понял условие
// задачи именно так. Я смотрел семинар, и там Вы говорили, что поменять 
// строки и столбцы можно только, если матрица (массив) квадратная. Но почему
// нельзя сделать матрицу, где количество столбцов в новой матрице будет равно
// количеству строк в старой и, соответственно количество строк в новой = 
// количеству столбцов в старой

// Метод FillArray, который заполняет двумерный массив
int[,] FillArray(int m, int n)
{
    int[,] outputArray = new int[m, n];
    Random rand = new Random();
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            outputArray[i, j] = rand.Next(-100, 100);
        }
    }
    
    return outputArray;
}

// Метод ChangeArray, который заменяет строки на столбцы 
int[,] ChangeArray(int[,] inputArray)
{
    int rowLenght = inputArray.GetLength(0);
    int colLenght = inputArray.GetLength(1);

    List<int> tmpList = new List<int>();
    int[,] outputArray = new int[colLenght, rowLenght];

    for (int i = 0; i < rowLenght; i++)
    {
        for (int j = 0; j < colLenght; j++)
        {
            outputArray[j, i] = inputArray[i, j];
        }
    }
    
    return outputArray;
}

// Метод PrintTwoDimArray, который переводит двумерный массив в строку для вывода в консоль
string PrintTwoDimArray(int [,] inputArray)
{
    string outputString = "";
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            outputString += $"{inputArray[i, j]}\t";
        }
        outputString +="\n";
    }
    
    return outputString;
}

// Метод GetConsoleData для считывания данных с консоли
void GetConsoleData(out int m, out int n)
{
    m = 0;
    n = 0;
    
    Console.WriteLine("Введите размер двумерного массива m на n");
    Console.Write("m = ");
    string? inputFirstLine = Console.ReadLine();
    Console.Write("n = ");
    string? inputSecondLine = Console.ReadLine();

    if (inputFirstLine != null && inputSecondLine != null)
    {
        m = int.Parse(inputFirstLine);
        n = int.Parse(inputSecondLine);
    }
}

try 
{
    //Считываем данные с консоли
    int m;
    int n;
    GetConsoleData(out m, out n);
    
    // Заполняем массив
    int[,] filledArray = FillArray(m, n);

    // Меняем массив согласно условиям задачи
    int[,] outputArray = ChangeArray(filledArray);

    // Выводим информацию в консоль
    Console.WriteLine($"Массив был:\n{PrintTwoDimArray(filledArray)}\nМассив стал:\n{PrintTwoDimArray(outputArray)}");

}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
