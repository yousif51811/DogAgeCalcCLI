// Made by Yousif51811
// Dog years calculation logic:
// First year: + 15
// Second year: + 9
// Anything After: + 5

Console.Write("Enter Your Age: ");
string? Input = Console.ReadLine();
double Age =  Convert.ToDouble(Input);
if ( Age <= 1 && Age > 0)
{
    double DogyearsAge = 15 * Age;
    Print(DogyearsAge);
}
else if (Age <= 2 && Age > 1)
{
    double DogyearsAge = ((Age -1) * 9) + 15;
    Console.WriteLine("Your Age in Dog Years is: " + DogyearsAge);
    Print(DogyearsAge);
}

else if (Age > 2)
{
    double DogyearsAge = ((Age - 2) * 5) + 24;
    Print(DogyearsAge);
}

// Account for invalid values (Negative Numbers, Zero, Characters, etc...)
else 
{
    Console.WriteLine("Enter A Valid Number"); 
}

// Function to print Age to prevent reusing the same line multiple times
static void Print(double Dogyears)
{
    Console.WriteLine("Your Age in Dog Years is: " + Dogyears);
}
