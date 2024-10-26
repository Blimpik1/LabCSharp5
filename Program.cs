using System;
using System.Collections;
using System.Collections.Generic;

public class MyPriorityQueue<T>
{
    private List<(T Item, int Priority)> queue = new List<(T, int)>();

    public void Enqueue(T item, int priority)
    {
        queue.Add((item, priority));
        queue.Sort((x, y) => y.Priority.CompareTo(x.Priority)); 
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        var item = queue[0].Item; 
        queue.RemoveAt(0);        
        return item;
    }
    public T Peek()
    {
        if (queue.Count == 0)
            throw new InvalidOperationException("Черга порожня.");

        return queue[0].Item; 
    }

    public bool IsEmpty()
    {
        return queue.Count == 0;
    }
}

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var priorityQueue = new MyPriorityQueue<string>();

        priorityQueue.Enqueue("Task A", 1);
        priorityQueue.Enqueue("Task B", 5);
        priorityQueue.Enqueue("Task C", 3);
        priorityQueue.Enqueue("Task D", 4);
        priorityQueue.Enqueue("Task E", 2);


        Console.WriteLine("Елемент з найвищим пріоритетом: " + priorityQueue.Peek());

       
        Console.WriteLine("Видаляємо елемент з найвищим пріоритетом: " + priorityQueue.Dequeue());

        
        Console.WriteLine("Новий елемент з найвищим пріоритетом: " + priorityQueue.Peek());


    }
}
