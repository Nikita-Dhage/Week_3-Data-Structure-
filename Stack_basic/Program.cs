Stack<string> myStack = new Stack<string>();

myStack.Push("First");
myStack.Push("Second");
myStack.Push("Third");
myStack.Push("Fourth");
Console.WriteLine("After pushing stack element");
foreach(var item in myStack)
Console.WriteLine(item);
Console.WriteLine("\nTop element using Peek(): " + myStack.Peek());
Console.WriteLine("\nPopped element: " + myStack.Pop());

Console.WriteLine("\nStack after popping one element:");
foreach (string item in myStack)
{
    Console.WriteLine(item);
}
myStack.Clear();
Console.WriteLine("\nStack after Clear():");