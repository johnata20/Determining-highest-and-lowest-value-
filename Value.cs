int inp, high = 0, low = 0, x = 1;

do
{
    if (x == 1)
        Console.Write("Enter the 1st number : ");
    else if (x == 2)
        Console.Write("Enter the 2nd number : ");
    else if (x == 3)
        Console.Write("Enter the 3rd number : ");
    else if (x == 4)
        Console.Write("Enter the 4th number : ");
    else if (x == 5)
        Console.Write("Enter the 5th number : ");
    inp = Convert.ToInt32(Console.ReadLine());

    if (inp > high)
        high = inp;

    if (x == 1)
        low = inp;
    else if (inp < low)
        low = inp;
    x++;
} while (x <= 5);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Highest number : {0}", high);
Console.WriteLine("Lowest number : {0}", low);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();