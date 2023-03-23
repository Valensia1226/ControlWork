string[] array = {"123", "Denmark", "-2", "computer science"};
Console.Write("[ ");
for (int i=0; i< array.Length; i++)
	Console.Write($"{array[i]} ");
Console.Write("] -> [ ");

for (int i=0; i< array.Length; i++)
	if (array[i].Length <= 3) Console.Write($"{array[i]} ");
Console.Write("]");