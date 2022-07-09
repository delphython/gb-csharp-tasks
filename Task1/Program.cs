string? inputFirstLine = Console.ReadLine();
string? inputSecondLine = Console.ReadLine();

if (inputFirstLine != null && inputSecondLine != null)
{
    int inputFirstNumber = int.Parse(inputFirstLine);
    int inputSecondNumber = int.Parse(inputSecondLine);

    if (inputSecondNumber == Math.Sqrt(inputFirstNumber))
    {
        Console.WriteLine(
            "The first number {0} is the square of the second number {1}",
            inputFirstNumber,
            inputSecondNumber
        );
    }
    else
    {
        Console.WriteLine(
            "The first number {0} is not the square of the second number {1}",
            inputFirstNumber,
            inputSecondNumber
        );
    }
}
