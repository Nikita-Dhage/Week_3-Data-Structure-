//---------Method 1 without giving size compile will auto compute the size of array-------//
int[] numbers = { 10, 20, 30, 40, 50 };
foreach (int num in numbers)

    Console.WriteLine("Element: " + num);




////------------Method 2 array initialization---------------//
int[] marks = new int[4];
marks[0] = 23;
marks[1] = 48;
marks[2] = 45;
marks[3] = 34;
for (int i = 0; i < marks.Length; i++)
    Console.WriteLine(marks[i]);




////-----------Method 3 taking values from user--------------//


Console.WriteLine("Enter array size :");
int size = int.Parse(Console.ReadLine());
int[] a = new int[size];
Console.WriteLine("Enter array element");
for (int i = 0; i < size; i++)

    a[i] = int.Parse(Console.ReadLine());

Console.WriteLine("Array elements are");
for (int i = 0; i < size; i++)
    Console.WriteLine(a[i]);
