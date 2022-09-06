Console.WriteLine("Ввидите число N: ");
int d1= Convert.ToInt32(Console.ReadLine());;

Console.WriteLine("Ввидите число М: ");
int d2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите число Z: ");
int d3 = Convert.ToInt32(Console.ReadLine());
int countNums = 50;

if (d1 * d2 * d3 > countNums)
{
    Console.Write("Error");
    return;
}

int[,,] resultNums =  matrix(d1, d2, d3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"{i},{j},{k} - {resultNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] matrix(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}