//------------------------ Решение задачи 40 ------------------------------
// Напишите программу, которая перевернёт одномерный массив (последний
//  элемент будет на первом месте, а первый - на последнем и т.д.)
//------------------------------------------------------------------------

// Метод reverseArray, который переворачивает одномерный массив
IEnumerable<int> reverseArray(int[] array)
{
    for(int i = array.Length-1; i >= 0; i--)
        yield return array[i];
}

try 
{
    // Входные данные
    int[] perfectArrayOne = new int[] {1,-2,3,-4,5};
    int[] perfectArrayTwo = new int[] {5,4,3,2,1,0};
    
    // Переворачиваем массив с помощью встроенного метода
    IEnumerable<int> reversedArrayOne = perfectArrayOne.Reverse();

    // Переворачиваем массив с помощью написанного метода
    IEnumerable<int> reversedArrayTwo = reverseArray(perfectArrayTwo);
    
    // Формируем строки для вывода массивов
    string lineOutputOne = string.Join(",", reversedArrayOne);
    string lineOutputTwo = string.Join(",", reversedArrayTwo);

    // Выводим информацию
    Console.Write(
        @$"Перевернутые массивы:
        [{lineOutputOne}]
        [{lineOutputTwo}]"
    );
}
catch (Exception e)
{
    // Выводим сообщение об ошибке
    Console.WriteLine($"Что-то здесь не так: {e}");
}
