Console.WriteLine("input rows count");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("input columns count");
int n = int.Parse(Console.ReadLine());
int [,] array = new int [5, 7];
FillArray(array);
PrintArray(array);
if (m > array.GetLength(0) || n > array.GetLength(1))
{
    Console.WriteLine("element doesn't exist");
}
else
{
    Console.WriteLine($"element is " + array[m, n]);
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}