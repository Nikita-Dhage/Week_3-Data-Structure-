public class StackArray
{
    int[] stack = new int[5]; 
    int top = -1;             
    public void Push(int value)
    {
       
        if (top == stack.Length - 1)
        { 
            Console.WriteLine("Stack is full! Cannot push " + value);
        }
        else
        {
            top++;              
            stack[top] = value;  
            Console.WriteLine(value + " pushed to stack."); 
        }
    }
    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty! Nothing to pop.");
        }
        else
        {
            Console.WriteLine(stack[top] + " popped from stack.");
            top--;
        }
    }
    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty! No top element.");
        }
        else
        {
            Console.WriteLine("Top element is: " + stack[top]);
        }
    }
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty! Nothing to display.");
        }
        else
        {
            Console.WriteLine("Stack elements are:");
            for (int i = top; i >= 0; i--) 
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
    public  bool IsEmpty()
    {
        return top == -1;
    }
    public int Count()
    {
        return top + 1;
    }
}
class Program
{
    static void Main()
    {
        StackArray myStack = new StackArray();

        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);
        myStack.Push(50);
        myStack.Push(60); 

        myStack.Peek();
        myStack.Display();

        myStack.Pop();
        myStack.Display();
        myStack.IsEmpty();
        Console.WriteLine("Is stack empty? " + myStack.IsEmpty()); 
        Console.WriteLine("Stack count: " + myStack.Count());      

        
    }
}
