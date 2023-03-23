string[] array = {"123", "Denmark", "-2", "computer science"};
Console.Write("[ ");
for (int i=0; i< array.Length; i++)
	Console.Write($"{array[i]} ");
Console.Write("] -> [ ");

string[] secondArray = new string[array.Length];
for (int i=0; i< array.Length; i++)
    if (array[i].Length <= 3) 
    {
        secondArray[i] = array[i];
        Console.Write($"{secondArray[i]} ");
    }

Console.Write("]");