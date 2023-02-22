namespace Stack_Demo;

public class OperationHandler 
{
    public Stack MyStack { get; set; }=new();
    public void Handle(string? result)
    {
        switch (result)
        {
            case "1":
                Console.WriteLine("Please enter your input:");
                MyStack.Push(Console.ReadLine());
                break;
            case "2":
                Console.WriteLine("Your output is:"+MyStack.Pop());
                Console.WriteLine("Press any key to see the menu");
                Console.ReadLine();
                Console.Clear();
                Menu.ShowMenu();

                break;
            case "3":
                MyStack.Clear();
                break;
        }

    }
}