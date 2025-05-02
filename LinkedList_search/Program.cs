
        LinkedList list = new LinkedList();
        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.InsertAtEnd(40);
        list.Display(); 
        list.Search(20);  
        list.Search(50); 
    
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
    public void Search(int value)
    {
        if (head == null)  
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node temp = head;
        int position = 1; 

        while (temp != null)
        {
            if (temp.data == value)
            {
                Console.WriteLine("Found " + value + " at position " + position);
                return;
            }
            temp = temp.next;
            position++;
        }
        Console.WriteLine(value + " not found in the list.");
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

