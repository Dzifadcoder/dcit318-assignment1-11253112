Console.WriteLine("=== Triangle Type Identifier ===");

int sideA;
while (true)
{
    Console.WriteLine("Enter the length of side A: "); 
    string sideAInput = Console.ReadLine();
    
    if (int.TryParse(sideAInput, out sideA))
    {
        if (sideA > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a positive number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
int sideB;
while (true)
{
    Console.WriteLine("Enter the length of side B: ");
    string sideBInput = Console.ReadLine();
    
    if (int.TryParse(sideBInput, out sideB))
    {
        if (sideB > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a positive number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
int sideC;
while (true)
{
    Console.WriteLine("Enter the length of side C: ");
    string sideCInput = Console.ReadLine();
    
    if (int.TryParse(sideCInput, out sideC))
    {
        if (sideC > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a positive number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

if (sideA == sideB && sideB == sideC)
{
    Console.WriteLine("The triangle is an equilateral triangle since all sides are equal.");
}
else if (sideA == sideB || sideB == sideC || sideA == sideC)
{
    Console.WriteLine("The triangle is an isosceles triangle since two sides are equal.");
}
else
{
    Console.WriteLine("The triangle is a scalene triangle since all sides are different.");

}
