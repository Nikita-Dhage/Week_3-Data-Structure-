LinkedStack stack = new LinkedStack();

stack.Push(10);
stack.Push(20);
stack.Push(30);
stack.Show();   
stack.Peek();   
stack.Pop();    
stack.Show();   
class StackNode
{
    public int Value;
    public StackNode Next;

    public StackNode(int val)
    {
        Value = val;
        Next = null;
    }
}
class LinkedStack
{
    private StackNode topNode;
    public void Push(int number)
    {
        StackNode newNode = new StackNode(number);
        newNode.Next = topNode; 
        topNode = newNode;      
        Console.WriteLine(number + " pushed onto the stack.");
    }
    public void Pop()
    {
        if (topNode == null)
        {
            Console.WriteLine("Stack is empty. Nothing to pop.");
            return;
        }

        Console.WriteLine(topNode.Value + " popped from the stack.");
        topNode = topNode.Next; 
    }
    public void Peek()
    {
        if (topNode == null)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.WriteLine("Top of stack: " + topNode.Value);
    }
    public bool IsEmpty()
    {
        return topNode == null;
    }
    public void Show()
    {
        if (topNode == null)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.WriteLine("Stack elements:");

        StackNode current = topNode;
        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

