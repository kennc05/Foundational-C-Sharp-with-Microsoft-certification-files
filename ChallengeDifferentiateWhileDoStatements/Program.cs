
/*
 Project 1: 

int number;
string? input;

do

{
    Console.WriteLine("Enter an integer value between 5 and 10: ");
    input = Console.ReadLine();
    bool validNumber = int.TryParse(input, out number);
    
    if (validNumber)
    {
        if (number >= 5 && number <= 10) 
            break;
        else
            Console.WriteLine($"You entered {input}. Please enter a number between 5 and 10.");
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (input != null);

Console.WriteLine($"Your input value ({number}) has been accepted.");

*/

/*
 * Project 2:
 
bool inputAccepted = false;

while (!inputAccepted)
{
    Console.WriteLine("Enter your role name (Administrator, Manager or User): ");
    string? input = Console.ReadLine();

    if (input != null)
    {
        switch (input.Trim().ToLower())
        {
            case "administrator":
            case "manager":
            case "user":
                Console.WriteLine($"Your input value ({input}) has been accepted.");
                inputAccepted = true;
                break;
            default:
                Console.Write($"The role name that you entered \"{input}\" is not valid. "); 
                break;
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid role name, please try again");
    }
}

*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
    int periodLocation = myStrings[i].IndexOf('.');

    while (periodLocation != -1)
    {
        Console.WriteLine(myStrings[i].Substring(0, periodLocation).TrimStart(' '));
        myStrings[i] = myStrings[i].Remove(0, periodLocation + 1);
        periodLocation = myStrings[i].IndexOf('.');

    } 
    Console.WriteLine(myStrings[i].TrimStart(' '));
    


}