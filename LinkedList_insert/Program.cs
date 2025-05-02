        LinkedList list = new LinkedList();
        list.InsertAtEnd(10);
        list.InsertAtBeginning(5);
        list.InsertAtEnd(20);
        list.InsertAtPosition(15, 3);
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

    //------------ Insert at the beginning-----------------//
    public void InsertAtBeginning(int value)
    {
        Node newNode = new Node(value);
        newNode.next = head;
        head = newNode;
    }

    //---------------- Insert at the end-----------------//
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

    //------------- Insert at a specific position---------------------//
    public void InsertAtPosition(int value, int position)
    {
        if (position < 1)
        {
            Console.WriteLine("Invalid position!");
            return;
        }

        Node newNode = new Node(value);

        if (position == 1)
        {
            newNode.next = head;
            head = newNode;
            return;
        }

        Node temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of range!");
            return;
        }

        newNode.next = temp.next;
        temp.next = newNode;
    }

    //------------------- Display the linked list-------------------------------//
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


