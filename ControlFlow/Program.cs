Console.WriteLine("Please enter the number of square metres you require:");
int squareMetres = int.Parse(Console.ReadLine());

if(!IsEligibleForAutoApply(squareMetres))
{
    Console.WriteLine("Sorry, you are not eligible for auto-apply. Please contact a sales representative for a quote");
    Console.ReadLine();
    return;
}

Console.WriteLine();
Console.WriteLine("Please choose a category for your wares");
Console.WriteLine("1 - Clothes");
Console.WriteLine("2 - Electronics");
Console.WriteLine("3 - Antiques");
Console.WriteLine("4 - Art");
Console.WriteLine("5 - Other");
int category = int.Parse(Console.ReadLine());

// interesting note: switch statement does not work for float and double
switch(category)
{
    case 1:
        Console.WriteLine("You chose: Clothes");
        break;
    case 2:
        Console.WriteLine("You chose: Electronics");
        break;
    case 3:
        Console.WriteLine("You chose: Antiques");
        break;
    case 4:
        Console.WriteLine("You chose: Art");
        break;
    case 5:
        Console.WriteLine("You chose: Other");
        break;
    default:
        Console.WriteLine("Could not recognise category");
        Console.ReadLine();
        return;
}
Console.ReadLine();

bool IsEligibleForAutoApply(int squareMetres)
{
    return squareMetres >= 2 && squareMetres <= 4;
}