string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    Console.WriteLine("Число {0}" + ((inputNumber%2 == 0) ? " четное." : " нечетное."), inputNumber);
}
