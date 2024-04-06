using System;

public class Node
{
    public string Spiderman { get; set; }
    public Node Next { get; set; }

    public Node(string spiderman)
    {
        Spiderman = spiderman;
        Next = null;
    }
}

public class MultiverseNodeCreator
{
    private Node head;
    private Node tail;
    private int length;

    public MultiverseNodeCreator()
    {
        head = null;
        tail = null;
        length = 0;
    }

    public void Push(string spiderman)
    {
        Node newSpiderman = new Node(spiderman);
        if (head == null || tail == null)
        {
            head = newSpiderman;
            tail = head;
        }
        else
        {
            tail.Next = newSpiderman;
            tail = newSpiderman;
        }
        length++;
    }

    public string Pop()
    {
        if (head == null)
        {
            return null;
        }

        Node currentSpiderman = head;
        Node previousSpiderman = null;

        while (currentSpiderman.Next != null)
        {
            previousSpiderman = currentSpiderman;
            currentSpiderman = currentSpiderman.Next;
        }

        tail = previousSpiderman;

        if (previousSpiderman == null)
        {
            head = null;
        }
        else
        {
            previousSpiderman.Next = null;
        }

        length--;
        return currentSpiderman.Spiderman;
    }

    public string Shift()
    {
        if (head == null)
        {
            return null;
        }

        Node shiftedSpiderman = head;
        head = head.Next;
        length--;

        if (head == null)
        {
            tail = null;
        }

        return shiftedSpiderman.Spiderman;
    }

    public void Unshift(string spiderman)
    {
        Node newSpiderman = new Node(spiderman);
        if (head == null)
        {
            head = newSpiderman;
            tail = head;
        }
        else
        {
            newSpiderman.Next = head;
            head = newSpiderman;
        }
        length++;
    }
}
