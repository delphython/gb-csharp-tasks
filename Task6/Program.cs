string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();
string? inputThirdLine = Console.ReadLine();

if (
    inputFirstLine != null && 
    inputSecondLine != null && 
    inputThirdLine != null
)
{
    int inputFirstNumber = int.Parse(inputFirstLine);
    int inputSecondNumber = int.Parse(inputSecondLine);
    int inputThirdNumber = int.Parse(inputThirdLine);

    Console.WriteLine(
        "Максимальным из чисел {0}, {1} и {2} является число {3}",
        inputFirstNumber,
        inputSecondNumber,
        inputThirdNumber,
        Math.Max(inputFirstNumber, Math.Max(inputSecondNumber, inputThirdNumber))
    );
}