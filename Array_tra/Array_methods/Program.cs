


int[] numbers = { 30, 10, 50, 20, 40 };

// ------------ 1. Sort the array (ascending) ------------
Array.Sort(numbers);  
Console.WriteLine("Sorted Array:");
foreach (int num in numbers)
{
    Console.WriteLine(num + " ");
}

// ------------ 2. Reverse the array ------------
Array.Reverse(numbers);  
Console.WriteLine("Reversed Array:");
foreach (int num in numbers)
{
    Console.WriteLine(num + " ");
}

// ------------ 3. Find index of a value ------------
int position = Array.IndexOf(numbers, 30);  
Console.WriteLine("Index of 30: " + position);  

// ------------ 4. Clear values from index 1 to 2 ------------
Array.Clear(numbers, 1, 2);  
Console.WriteLine("Array after Clear:");
foreach (int num in numbers)
{
    Console.WriteLine(num + " ");
}

// ------------ 5. Copy array to another array ------------
int[] copiedArray = new int[5];  
Array.Copy(numbers, copiedArray, numbers.Length);  
Console.WriteLine("Copied Array:");
foreach (int num in copiedArray)
{
    Console.WriteLine(num + " ");
}

