class SimpleQueue
{
    int[] queue = new int[5];  
    int front = -1;            
    int rear = -1;             
 public void Enqueue(int value)
    {
        if (rear == queue.Length - 1) 
        {
            Console.WriteLine("Queue is full! Cannot enqueue.");
            return;
        }

        if (front == -1) 
            front = 0;

        rear++;                 
        queue[rear] = value;    
        Console.WriteLine(value + " added to queue.");
    }
public void Dequeue()
    {
        if (front == -1 || front > rear) 
        {
            Console.WriteLine("Queue is empty! Cannot dequeue.");
            return;
        }

        Console.WriteLine(queue[front] + " removed from queue.");
        front++; 
       if (front > rear)
        {
            front = rear = -1;
        }
    }
    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return;
        }

        Console.WriteLine("Front element is: " + queue[front]);
    }
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty!");
            return;
        }

        Console.WriteLine("Queue elements:");
        for (int i = front; i <= rear; i++)
        {
            Console.WriteLine(queue[i]);
        }
    }
     public bool IsEmpty()
    {
        return front == -1 || front > rear;
    }
    public int Count()
    {
        if (IsEmpty())
            return 0;
        return rear - front + 1;
    }
}
class Program
{
    static void Main()
    {
        SimpleQueue q = new SimpleQueue();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        q.Display();        
        q.Peek();          

        q.Dequeue();       
        q.Display(); 

        Console.WriteLine("Is queue empty? " + q.IsEmpty()); 
        Console.WriteLine("Total elements: " + q.Count());   

        q.Dequeue();        
        q.Dequeue();        
        q.Dequeue();        

        q.Display();        
        Console.WriteLine("Is queue empty? " + q.IsEmpty()); 
        Console.WriteLine("Total elements: " + q.Count());   
    }
}

