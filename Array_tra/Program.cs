
int[] numbers = { 5, 10, 15, 20, 25 };

// 1. Traversing: Print all elements
Console.WriteLine("Array elements:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Element at index {i}: {numbers[i]}");
}

// 2. Sum of elements
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"\nSum of elements: {sum}");

// 3. Find maximum and minimum elements
int max = numbers[0];
int min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        max = numbers[i];

    if (numbers[i] < min)
        min = numbers[i];
}

Console.WriteLine($"Maximum element: {max}");
Console.WriteLine($"Minimum element: {min}");

// 4. Reverse the array
Console.WriteLine("\nReversed array:");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}
