// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== Ticket Price Calculator ===");
Console.WriteLine("Welcome! Let's calculate your ticket price based on your age.");
Console.WriteLine();

int userAge;

while (true)
{
    Console.Write("Enter your age: ");
    string ageInput = Console.ReadLine();
    
    if (int.TryParse(ageInput, out userAge))
    {
        if (userAge > 0 && userAge <= 150)
        {
            Console.WriteLine($"You entered: {userAge} years old");
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid age between 1 and 150.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number for your age.");
    }
}

Console.WriteLine();
Console.WriteLine("=== Ticket Price Calculation ===");

decimal ticketPrice;

if (userAge <= 12)
{
    ticketPrice = 7;
    Console.WriteLine("Category: Child (12 and below)");
}
else if (userAge >= 65)
{
    ticketPrice = 7;
    Console.WriteLine("Category: Senior Citizen (65 and above)");
}
else
{
    ticketPrice = 10;
    Console.WriteLine("Category: Adult (13-64)");
}

Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
Console.WriteLine();
Console.WriteLine("Thank you for using our ticket calculator!");

