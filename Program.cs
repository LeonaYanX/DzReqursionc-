// Реализовать вывод массива с помощью рекурсии.
/*Console.WriteLine("Enter the Array size");
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
PrintArray(myArray);*/
//Console.ReadLine();
// Find the Sum of Array elements with reqursion.

/*int Sum(int[] array , int size , int sum)
{
    if (size-1<=0)
    {
        sum = sum + array[0];
        return sum;
    }
    sum =  Sum(array, size - 1, sum) + array[size-1];    
    Console.WriteLine($"After reqursion size = {size} and sum = {sum}");
    return sum;
}
int[] myArray = {1,2,3,4};
int mySize = myArray.Length;
int mySum = 0;
 mySum = Sum(myArray , mySize , mySum );
Console.WriteLine(mySum);*/
//Найти сумму цыфр числа с помощью рекурсии.
int number = 333;

int SumOfDigits(int num, int sum = 0)
{
    if (num<=0)
    {
        return sum;
    }
    sum = sum + num%10 + SumOfDigits(num/10);
    return sum;
}
int mysum = SumOfDigits(number);
Console.WriteLine(mysum);
Console.ReadLine();
