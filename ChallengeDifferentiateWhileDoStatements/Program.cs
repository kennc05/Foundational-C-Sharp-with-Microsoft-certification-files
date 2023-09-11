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