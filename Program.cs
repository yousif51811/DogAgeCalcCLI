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
    double DogyearsAge = ((Age -1) * 5) + 15;
    Console.WriteLine("Your Age in Dog Years is: " + DogyearsAge);
    Print(DogyearsAge);
}
else if (Age > 2)
{
    double DogyearsAge = ((Age - 2) * 5) + 24;
    Print(DogyearsAge);
}
else
{
    Console.WriteLine("Enter A Valid Number");
}
static void Print(double Dogyears)
{
    Console.WriteLine("Your Age in Dog Years is: " + Dogyears);
}
