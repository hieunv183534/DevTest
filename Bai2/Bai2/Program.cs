// See https://aka.ms/new-console-template for more information
using Bai2;

Console.WriteLine("Hello, World!");

var bai2Context = new Bai2Context();

var run = true;
while (run)
{
    List<int> listNumber = new List<int>();

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Input the list:(Enter empty to end)");
    while (true)
    {
        string valueInt = Console.ReadLine();
        if (string.IsNullOrEmpty(valueInt))
        {
            break;
        }
        try
        {
            listNumber.Add(int.Parse(valueInt));
        }
        catch
        {
            Console.WriteLine("Invalid element!");
        }
    }


    Console.WriteLine("Your numbers: " + String.Join(" ", listNumber));

    Console.WriteLine("Choose your strategy for resolve: ");
    Console.WriteLine("1. Dynamic Programing");
    Console.WriteLine("2. Backtracking");
    Console.Write("Your choose: ");
    var choose = Console.ReadKey();
    Console.WriteLine();
    switch (choose.KeyChar)
    {
        case '1':
            bai2Context.SetStrategy(new Bai2DynamicProgrammingStrategy());
            bai2Context.Resolve(listNumber);
            break;
        case '2':
            bai2Context.SetStrategy(new Bai2BacktrackingStrategy());
            bai2Context.Resolve(listNumber);
            break;
        default:
            Console.WriteLine("Invalid choose!");
            break;
    }


    Console.WriteLine("Do you want to continue using it? (y/Y for yes)");
    var continueStr = Console.ReadKey();
    Console.WriteLine();
    if (continueStr.KeyChar == 'y' || continueStr.KeyChar == 'Y')
        run = true;
    else run = false;
}
