
LinkedList list = new LinkedList();
list.Insert(10);
list.Insert(20);
list.Insert(30);
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
    public void Insert(int value)
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
            Console.Write(temp.data + "->");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }
}
