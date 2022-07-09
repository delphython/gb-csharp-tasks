string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    string[] dayOfWeek = {
        "понедельник",
        "вторник",
        "среда",
        "четверг",
        "пятница",
        "суббота",
        "воскресенье"
    };

    Console.WriteLine(
        "Номеру {0} соотвествует день недели: {1}.",
        inputNumber,
        dayOfWeek[inputNumber-1]
    );
}
