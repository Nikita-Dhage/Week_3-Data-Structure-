
LinkedList list = new LinkedList();
        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.InsertAtEnd(40);
        list.Display();  
        list.DeleteFromFront();  
        list.Display();  
        list.DeleteFromEnd();  
        list.Display();  

        list.DeleteAtPosition(1);  
        list.Display(); 
class Node
{
    public int data;
    public Node next;
    public Node(int value)
    {
        data = value;
        next = null;
    }
}
class LinkedList
{
    private Node head; 
    public void InsertAtEnd(int value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }
   //---------Delete from front------//
   public void DeleteFromFront()
    {
        if (head == null)  
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Console.WriteLine("Deleted from front: " + head.data);
        head = head.next;  
    }

    //----------- Delete from the end------------------//
    public void DeleteFromEnd()
    {
        if (head == null) 
        {
            Console.WriteLine("List is empty.");
            return;
        }
        if (head.next == null)
        {
            Console.WriteLine("Deleted from end: " + head.data);
            head = null;
            return;
        }

       
        Node temp = head;
        while (temp.next != null && temp.next.next != null)
        {
            temp = temp.next;
        }

        Console.WriteLine("Deleted from end: " + temp.next.data);
        temp.next = null;  
    }

    //-------- Delete at a specific position----------//
    public void DeleteAtPosition(int position)
    {
        if (head == null)  
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (position < 1) 
        {
            Console.WriteLine("Invalid position.");
            return;
        }
        if (position == 1)
        {
            Console.WriteLine("Deleted at position " + position + ": " + head.data);
            head = head.next;
            return;
        }
        Node temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.next;
        }

        if (temp == null || temp.next == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }

        Console.WriteLine("Deleted at position " + position + ": " + temp.next.data);
        temp.next = temp.next.next;  
    }

   
    public void Display()
    {
        if (head == null)  
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node temp = head;
        Console.Write("Linked List: ");
        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
}



