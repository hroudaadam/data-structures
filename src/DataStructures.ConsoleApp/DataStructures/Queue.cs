namespace DataStructures.ConsoleApp.DataStructures.Queue;

public static class QueueExample
{
    public static void Run()
    {
        Queue q = new();
        q.Enqueue(5);
        q.Enqueue(13);
        q.Enqueue(1);
        q.Enqueue(3);
        Console.WriteLine(q);

        Console.WriteLine(q.Dequeque());
        Console.WriteLine(q.Peek());
    }
}

public class Queue
{
    public int Count { get; private set; } = 0;
    private QueueNode _first;
    private QueueNode _last;

    public void Clear()
    {
        _first = null;
        _last = null;
        Count = 0;
    }

    public void Enqueue(int value)
    {
        QueueNode newNode = new(value);
        if (Count <= 0)
        {
            _last = newNode;
            _first = newNode;
        }
        else
        {
            _last.Next = newNode;
            _last = newNode;
        }

        Count++;
    }

    public int Dequeque()
    {
        if (Count < 1) throw new InvalidOperationException("Queue is empty");

        QueueNode tmp = _first;
        _first = _first.Next;

        if (Count == 1)
        {
            _last = null;
        }

        Count--;
        return tmp.Value;
    }

    public int Peek()
    {
        return _first.Value;
    }

    public override string ToString()
    {
        QueueNode curr = _first;
        List<int> values = new();

        while (curr != null)
        {
            values.Add(curr.Value);
            curr = curr.Next;
        }

        return string.Join(", ", values);
    }
}

class QueueNode
{
    public int Value { get; set; }
    public QueueNode Next { get; set; }

    public QueueNode(int value)
    {
        Value = value;
    }

    public QueueNode(int value, QueueNode next)
    {
        Value = value;
        Next = next;
    }
}
