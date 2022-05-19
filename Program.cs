
while (true)
{
    Console.WriteLine("Hello! Welcome to your shopping list!");
    Console.Write("How many people are we making PB&J sandwiches for? ");


    int sandwiches = int.Parse(Console.ReadLine());


    double totalSlicesNeeded = sandwiches * 2;
    double tablespoonsPB = sandwiches * 2;
    double teaspoonsJelly = sandwiches * 4;

    double totalLoaves = (double)Math.Ceiling(totalSlicesNeeded / 28);

    double jarsOfPb = (double)Math.Ceiling(tablespoonsPB / 32);

    double jarsOfJelly = (double)Math.Ceiling(teaspoonsJelly / 48);


    Console.WriteLine("You need: ");
    Console.WriteLine(totalSlicesNeeded + " slices of bread");
    Console.WriteLine(tablespoonsPB + " tablespoons of peanut butter");
    Console.WriteLine(teaspoonsJelly + "teaspoons of jelly");

    Console.WriteLine();
    Console.WriteLine("Which equals...");

    Console.WriteLine(totalLoaves + " loaves of bread");
    Console.WriteLine(jarsOfPb + " jars of peanut butter");
    Console.WriteLine(jarsOfJelly + " jars of jelly");

    while (true)
    {
        Console.WriteLine("Would you like to restart? Enter YES or Y to continue, or enter any other key to exit");
        string restart = Console.ReadLine().ToUpper();
        if (restart == "Y")
            break;
        else if (restart == "YES")
            break;
        else
            return;

    }

}