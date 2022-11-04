namespace DataStructures.ConsoleApp.DataStructures.LinkedList;

public static class LinkedListExample
{
    public static void Run()
    {
        LinkedList ll = new();
        ll.AddFirst(1);
        ll.AddBefore(5, ll.First);
        ll.AddBefore(7, ll.First);
        ll.AddBefore(5, ll.First);
        ll.RemoveFirst();
        ll.Remove(ll.First);

        Console.WriteLine(ll);
        Console.WriteLine(ll.Count);
    }
}

public class LinkedList
{
    public LinkedListNode First { get; private set; }
    public int Count { get; private set; } = 0;

    public void AddBefore(int newValue, LinkedListNode prevNode)
    {
        LinkedListNode tmp = prevNode.Next;
        LinkedListNode newNode = new(newValue);
        newNode.Next = tmp;
        prevNode.Next = newNode;

        Count++;
    }

    public void AddFirst(int newValue)
    {
        LinkedListNode tmp = First;
        First = new(newValue)
        {
            Next = tmp
        };

        Count++;
    }

    public void Clear()
    {
        First = null;
        Count = 0;
    }

    public void Remove(LinkedListNode nodeToDelete)
    {
        LinkedListNode prev = null;
        LinkedListNode curr = First;
        // travers list
        while (curr != null)
        {
            // found node to delete
            if (curr == nodeToDelete)
            {
                // remove first
                if (prev == null)
                {
                    RemoveFirst();
                }
                // remove other
                else
                {
                    prev.Next = curr.Next;
                    Count--;
                }
                return;
            }
            // travers step
            prev = curr;
            curr = curr.Next;
        }

        // not found
        throw new InvalidOperationException("Node was not found");
    }

    public void RemoveFirst()
    {
        First = First.Next;
        Count--;
    }

    public LinkedListNode Search(int value)
    {
        LinkedListNode curr = First;
        // travers list
        while (curr != null)
        {
            // found node
            if (curr.Value == value)
            {
                return curr;
            }
            // travers step
            curr = curr.Next;
        }
        // not found
        return null;
    }

    public override string ToString()
    {
        List<int> values = new();
        LinkedListNode curr = First;
        while (curr != null)
        {
            values.Add(curr.Value);
            curr = curr.Next;
        }
        return string.Join(", ", values);
    }
}

public class LinkedListNode
{
    public int Value { get; set; }
    public LinkedListNode Next { get; set; }

    public LinkedListNode(int value)
    {
        Value = value;
    }
}
