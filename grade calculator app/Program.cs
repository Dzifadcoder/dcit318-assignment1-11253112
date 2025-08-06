// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== Grade Calculator ===");
Console.WriteLine("Welcome! Enter your grade to see your letter grade.");

int userGrade;

while (true){
    Console.WriteLine("Enter your numerical grade (0-100): ");
    string userGradeInput = Console.ReadLine();

    if (int.TryParse(userGradeInput, out userGrade)){
        if (userGrade >= 0 && userGrade <=100){
            Console.WriteLine($"You entered : {userGrade}");
            break;        
        } 
        else 
        {
            Console.WriteLine("Invalid input. Please enter a valid numerical grade between 0 and 100.");
        }
    } 
    else 
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}


if (userGrade >= 90)
{
    Console.WriteLine("You grade is: A");
}
else if (userGrade >= 80)
{
    Console.WriteLine("You grade is: B");
}
else if (userGrade >= 70)
{
    Console.WriteLine("You grade is: C");
}
else if (userGrade >= 60)
{
    Console.WriteLine("You grade is: D");
}
else
{
    Console.WriteLine("You grade is: F");
}
