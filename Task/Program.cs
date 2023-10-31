﻿namespace Acme.Collections;

public class Stack<T>
{
    Entry _top;
    public void Push(T data)
    {
        _top = new Entry(_top, data);
    }
    public T Pop()
    {
        if( _top == null)
        {
            throw new InvalidOperationException();
        }
        T result = _top.Data;
        _top = _top.Next;

        return result;
    }
    Class Entry
    {
        public Entry Next { get; set; }
        public T Data { get; set; }

        public Entry(Entry next, T data)
    {
        Next = next;
        Data = data;
    }
    }
}

class Example
{
    public static void Main()
    {
        var s = new Acme.Collections.Stack<int>();
        s.Push(1);
        s.Push(10);
        s.Push(100);
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());

    }
}