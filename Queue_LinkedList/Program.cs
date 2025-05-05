LinkedQueue queue = new LinkedQueue();

queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

queue.Show();   

queue.Peek();   

queue.Dequeue();

queue.Show();

class QueueNode
{
    public int Value;
    public QueueNode Next;

    public QueueNode(int val)
    {
        Value = val;
        Next = null;
    }
}
class LinkedQueue
{
    private QueueNode front;
    private QueueNode rear;
    public void Enqueue(int number)
    {
        QueueNode newNode = new QueueNode(number);

        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }

        Console.WriteLine(number + " added to the queue.");
    }
    public void Dequeue()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is empty. Nothing to dequeue.");
            return;
        }

        Console.WriteLine(front.Value + " removed from the queue.");
        front = front.Next;

        if (front == null)
        {
            rear = null;
        }
    }
    public void Peek()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine("Front of queue: " + front.Value);
    }
    public bool IsEmpty()
    {
        return front == null;
    }
    public void Show()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.WriteLine("Queue elements :");

        QueueNode current = front;
        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

