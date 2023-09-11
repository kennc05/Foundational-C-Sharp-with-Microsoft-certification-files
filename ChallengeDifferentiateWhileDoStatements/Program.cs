
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