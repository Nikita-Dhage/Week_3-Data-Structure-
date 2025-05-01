  
        int[] numbers = new int[5];
        int size = 0;  
        Console.WriteLine("Insert 3 numbers:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter number: ");
            numbers[i] = int.Parse(Console.ReadLine());
            size++; 
        }
        Console.WriteLine("Array after insertion:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Enter new value to update at position 1: ");
        numbers[1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Array after update:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        for (int i = 1; i < size - 1; i++)
        {
            numbers[i] = numbers[i + 1];  
        }
        size--;  
        Console.WriteLine("Array after deletion:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    