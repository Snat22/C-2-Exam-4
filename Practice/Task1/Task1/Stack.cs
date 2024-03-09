﻿namespace Task1;

public class Stack<T>
{
    List<T>_list = new List<T>();

    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.Count == 0)
        {
            System.Console.WriteLine("Stack Pustoy");
        }
            T item = _list[_list.Count-1];
            _list.RemoveAt(_list.Count-1);
            return item;
    }

    public T Peek()
    {
        if (_list.Count == 0)
        {
            System.Console.WriteLine("Stack Pustoy");
        }
        return _list[_list.Count-1];
    }
}
