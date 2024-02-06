// Реализовать вывод массива с помощью рекурсии.
Console.WriteLine("Enter the Array size");
string input = Console.ReadLine() ?? "NO DATA";

int IsIntCycle(string input)
{
    int size;
    bool IsInt = int.TryParse(input, out size);
    
    while (IsInt != true)
    {
        Console.WriteLine("Enter the Array size int please");
        input = Console.ReadLine() ?? "No Data";
        IsInt = int.TryParse(input ,out size);
    }
    return size;
}
int mySize = IsIntCycle(input);
int[]myArray = new int[mySize];
int[] FillArray(int[] array) 
{
Random random = new Random();
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = random.Next(-33,34);
    }
    return array;
} 
myArray = FillArray(myArray);
void PrintArray( int[]array, int i = 0) 
{
    
    if (i>=array.Length)
    {
        Console.WriteLine("End");
        return;
    }
    Console.Write(array[i] + "\t");
    PrintArray(array, i+1);
}
PrintArray(myArray);
Console.ReadLine();