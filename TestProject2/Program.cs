/*int heroHealth = 10;
int enemyHealth = 10;
int heroHit = 0;
int enemyHit = 0;
Random rand = new();

do
{
    heroHit = rand.Next(1,11);
    enemyHealth -= heroHit;
    Console.WriteLine($@"Enemy was damaged and lost {heroHit} health and now has {enemyHealth} health.");
    
    if (enemyHealth <= 0) continue;   

    enemyHit = rand.Next(1, 11);
    heroHealth -= enemyHit;
    Console.WriteLine($@"Hero was damaged and lost {enemyHit} health and now has {heroHealth} health.");

} while (heroHealth > 0 && enemyHealth > 0);

string winner = (heroHealth > enemyHealth ? "Hero Wins!" : "Enemy Wins!");
Console.WriteLine($@"{winner}");*/

/*string? input;
Console.WriteLine($@"Input a number between 5 and 10");
bool entry = false;
int isInt = 0;

do
{
    input = Console.ReadLine();
    bool tryInt = int.TryParse(input, out isInt);
    if (tryInt != false)
        if (isInt > 5 && isInt < 11)
            entry = true;
        
        else
            Console.WriteLine($@"Only numbers between 5 and 10 excluding both");

    else
        Console.WriteLine($@"Input a valid number");
} while (entry == false);*/

/*string[] roles = {"Administrator", "Manager", "User"};
bool entry = false;
Console.WriteLine($@"Enter your role name: ");
string? input;

do
{
    input = Console.ReadLine();
    
    if (input != "")
    {

        foreach (string role in roles)
        {
            if (input == role.Trim().ToLower() || input == role)
            {
                entry = true;
                break;
            }
        }    
        if ( entry == false)
        {
            Console.WriteLine($@"The role name that you entered, {input} is not valid. Enter your role name (Administrator, Manager, or User).");
        }
    }
    else
    {
        Console.WriteLine($@"Retry");
    }
    
} while (entry == false);

Console.WriteLine($@"Your input value ({input}) has been accepted."); */

/*string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int arrLength = myStrings.Length;

for (int i = 0; i < arrLength; i++)
{
    string myString = myStrings[i];
    int x = myString.IndexOf(".");

    while (x != -1)
    {
        string mySentence = myString.Remove(x);

        myString = myString.Substring(x+1);

        myString = myString.TrimStart();

        Console.WriteLine($@"{mySentence}");

        x = myString.IndexOf(".");
    }

    Console.WriteLine($@"{myString.Trim()}");
}*/