using System;
using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public StackOfStrings()
    {
        data = new List<string>();
    }

    public void Push(string item)
    {
        data.Add(item);
    }

    public bool IsEmpty()
    {
        if (data.Count == 0)
        {
            return true;
        }

        return false;
    }

    public string Peek()
    {
        if (IsEmpty())
        {
            throw new ArgumentException("Stack is empty");
        }

        int lastIndex = data.Count - 1;

        return data[lastIndex];
    }

    public string Pop()
    {
        if (IsEmpty())
        {
            throw new ArgumentException("Stack is empty");
        }

        int lastIndex = data.Count - 1;
        data.RemoveAt(lastIndex);
        return Peek();

    }
}