int[,] CreateArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SquareElemWithEqualIndexes(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)
        for(int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
}

int SumOnMainDiag(int[,] array)
{
    int minSize;
    minSize = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
    /*
    if (array.GetLength(0) > array.GetLength(1)) 
        minSize = array.GetLength(1);
    else 
        minSize = array.GetLength(0);
    */

    // int minSize = Math.Min(array.GetLength(0), array.GetLength(1));
    int sum = 0;
    for (int i = 0; i < minSize; i++)
        sum += array[i, i];

    return sum;
}

int[,] myArray = CreateArray();
Show2dArray(myArray);
SquareElemWithEqualIndexes(myArray);
Show2dArray(myArray);
int sumElem = SumOnMainDiag(myArray);
Console.WriteLine(sumElem);