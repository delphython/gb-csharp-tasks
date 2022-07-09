string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int start = 1;
    int i = 0;
    int arrayLenght = inputNumber/2;
    int[] evenNumbersArray = new int[arrayLenght];
    
    while (start <= inputNumber)
    {
        if (start%2 == 0)
        {
            evenNumbersArray[i] = start;
            i++;
        }
        start++;
    }

    string lineOutput = string.Join(", ", evenNumbersArray);

    Console.WriteLine(lineOutput);
}
