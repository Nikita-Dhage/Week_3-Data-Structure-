int[] oldArray = { 10, 20, 30 }; 
int newValue = 5;
int[] newArray = new int[oldArray.Length + 1];

//-----------At the begining place element------------------//
newArray[0] = newValue;

for (int i = 0; i < oldArray.Length; i++)
{
    newArray[i + 1] = oldArray[i];
}

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}

//-------------At the specific position---------------//
int position = 2;
for (int i = 0; i < position; i++)
{
    newArray[i] = oldArray[i];
}

newArray[position] = newValue;
for (int i = position; i < oldArray.Length; i++)
{
    newArray[i + 1] = oldArray[i];
}
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}


//--------------------At the ending-----------------------//



for (int i = 0; i < oldArray.Length; i++)
{
    newArray[i] = oldArray[i];
}


newArray[newArray.Length - 1] = newValue;


for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}
