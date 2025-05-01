int[] numbers = { 10, 20, 30, 40 };
//---------Update ele by index--------//


numbers[1] = 25;
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");  
}


////---------Update all ele in array-----------//

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] * 2;  
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");  
}

