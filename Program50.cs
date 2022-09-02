Console.WriteLine("Ввидите число М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите координату  Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

int[,] matr = FillMatrix(m, n, -10, 10);

PrintMatrix(matr);
void PrintMatrix(int[,] matrix)

{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
       Console.Write( matrix[i, j] + " ");
      }
       Console.WriteLine();
    }
}

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
 {
  int[,] matrix = new int[rowsCount, columnsCount];
  Random rand = new Random();

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      for(int i = 0; i < matrix.GetLength(0); i++)
      {
        matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        
      }
    }
   
    Console.WriteLine("Число в матрице: " + matrix[X, Y]);

    Console.WriteLine();
return matrix;
 }