namespace DataStructures.ConsoleApp.DataStructures.Stack;


public static class StackExample
{
    public static void Run()
    {
        Stack s = new();
        s.Push(1);
        s.Push(5);
        s.Push(13);
        s.Push(18);
        Console.WriteLine(s.Peek());
        Console.WriteLine(s.Pop());

        Console.WriteLine(s);
    }
}

public class Stack
{
    public int Count { get; private set; } = 0;
    private StackNode _top;

    public void Clear()
    {
        _top = null;
        Count = 0;
    }

    public int Peek()
    {
        if (Count <= 0) throw new InvalidOperationException("Stack is empty");

        return _top.Value;
    }

    public int Pop()
    {
        if (Count <= 0) throw new InvalidOperationException("Stack is empty");

        StackNode tmp = _top;
        _top = _top.Next;
        Count--;

        return tmp.Value;
    }

    public void Push(int value)
    {
        StackNode newNode = new(value, _top);
        _top = newNode;
        Count++;
    }

    public override string ToString()
    {
        List<int> values = new();
        StackNode curr = _top;

        while (curr != null)
        {
            values.Add(curr.Value);
            curr = curr.Next;
        }

        return string.Join(", ", values);
    }
}

class StackNode
{
    public int Value { get; set; }
    public StackNode Next { get; set; }

    public StackNode(int value, StackNode next)
    {
        Value = value;
        Next = next;
    }
}
