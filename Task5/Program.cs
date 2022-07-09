string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();

if (inputFirstLine != null && inputSecondLine != null)
{
    int inputFirstNumber = int.Parse(inputFirstLine);
    int inputSecondNumber = int.Parse(inputSecondLine);

    Console.WriteLine(
        "Максимальным из чисел {0} и {1} является число {2}",
        inputFirstNumber,
        inputSecondNumber,
        Math.Max(inputFirstNumber, inputSecondNumber)
    );
}
