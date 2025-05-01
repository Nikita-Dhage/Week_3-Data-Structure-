int[] oldArray = { 10, 20, 30, 40 };
int[] newArray = new int[oldArray.Length - 1];
//specific position//
int position = 2; 

int j = 0;

for (int i = 0; i < oldArray.Length; i++)
{
    if (i != position)
    {
        newArray[j] = oldArray[i];
        j++;
    }
}

//-------------from last position---------------------//

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = oldArray[i];
}

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}
