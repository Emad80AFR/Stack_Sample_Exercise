namespace Stack_Demo;

public class Stack
{
    public int Current { get;private set; }
    public List<object?> MyStack{ get; }

    public Stack()
    {
        Current = -1;
        MyStack = new List<object?>();
    }

    public void Push(object? item)
    {
        Console.Clear();
        if (item==null)
           throw new InvalidOperationException();
            
        MyStack.Add(item);
        Current++;
        Menu.ShowMenu();
    }

    public object? Pop()
    {
        Console.Clear();

        if (Current==-1)
            throw new InvalidOperationException();

        var item = MyStack[Current];
        Current--;
        return item;
    }

    public void Clear()
    {
        Console.Clear();

        MyStack.Clear();
        Current = -1;
        Menu.ShowMenu();

    }
}