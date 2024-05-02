Console.WriteLine("Please enter the number of square metres you require:");
int squareMetres = int.Parse(Console.ReadLine());

if(!IsEligibleForAutoApply(squareMetres))
{
    Console.WriteLine("Sorry, you are not eligible for auto-apply. Please contact a sales representative for a quote");
    Console.ReadLine();
    return;
}


bool IsEligibleForAutoApply(int squareMetres)
{
    return squareMetres >= 2 && squareMetres <= 4;
}