Console.WriteLine($@"Enter a value between 5 and 10");

int value = 0;
bool entry = false;

do
{
    string? intValue = Console.ReadLine();
    bool x = int.TryParse(intValue, out value);
    if (x == true)
        if (value > 5 && value < 11)
            entry = true;
        else
            Console.WriteLine($@"Please input a number between 5 and 10.");
    else
        Console.WriteLine($@"Input a number please.");

} while (entry == false);

