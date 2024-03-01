// See https://aka.ms/new-console-template for more information
using Coca;

Console.WriteLine("Hello, World!");

bool run = true;
var cocaContext = new CocaContext();

while (run)
{
    Console.WriteLine("Input the init coca count:");
    try
    {
        var initCount = int.Parse(Console.ReadLine());
        if(initCount < 0 || initCount > 100000)
        {
            Console.WriteLine("Coca count can only be within the range of 1 to 1000!");
            continue;
        }
        else cocaContext.CocaInitCount = initCount;

    }
    catch
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    Console.WriteLine("Choose your strategy for calculate: ");
    Console.WriteLine("1. Strategy1");
    Console.WriteLine("2. Strategy2");
    Console.Write("Your choose: ");
    var choose = Console.ReadKey();
    Console.WriteLine();
    switch (choose.KeyChar)
    {
        case '1':
            cocaContext.SetStrategy(new CocaCalculate1Strategy());
            Console.WriteLine("Result: " + cocaContext.Calculate());
            break;
        case '2':
            cocaContext.SetStrategy(new CocaCalculate2Strategy());
            Console.WriteLine("Result: " + cocaContext.Calculate());
            break;
        default:
            Console.WriteLine("Invalid choose!");
            break;
    }


    Console.WriteLine("Do you want to continue using it? (y/Y for yes)");
    var continueStr =  Console.ReadKey();
    Console.WriteLine();
    if (continueStr.KeyChar == 'y' || continueStr.KeyChar == 'Y')
        run = true;
    else run = false;
}

Console.WriteLine("Thanks!");