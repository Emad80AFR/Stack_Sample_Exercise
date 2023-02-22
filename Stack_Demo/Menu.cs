namespace Stack_Demo;

public static class Menu
{
    public static OperationHandler Handler { get; } = new();

    public static void ShowMenu()
    {
        Console.WriteLine("Please enter a valid input (1-3):");
        Console.WriteLine("1.Push from stack\n" +
                          "2.Pop from stack\n" +
                          "3.Clear stack");
        var result = Console.ReadLine();
        while (result != null && (int.Parse(result) > 3 || int.Parse(result) < 1))
        {
            Console.WriteLine("Invalid input!\n" +
                              "Please try again");
            result = Console.ReadLine();
        }
        Handler.Handle(result);
    }
}