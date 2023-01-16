Console.WriteLine("input M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("input N");
int n = int.Parse(Console.ReadLine());

double [,] array = new double[m, n];
FillArray(array);
PrintArray(array);

void PrintArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
    }
}

void FillArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(10, 100);
        }
    
}

}
