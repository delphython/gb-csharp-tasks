string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    // int inputNumber = int.Parse(inputLine);
    // int outputNumber = inputNumber % 10;
    
    char outputNumber = inputLine[inputLine.Length - 1];

    Console.WriteLine(outputNumber);
    Console.WriteLine(
        "Последняя цифра числа {0} равна {1}.",
        inputLine,
        outputNumber
    );
}
