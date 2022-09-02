Console.WriteLine("Ввидите число М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matr = FillMatrix(m, n, 1,50);

PrintMatrix(matr);
void PrintMatrix(double[,] matrix)

{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
       Console.Write( matrix[i, j] + ", ");
      }
      Console.WriteLine();
    }
}

double[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
 {
  double[,] matrix = new double[rowsCount, columnsCount];
  Random rand = new Random();

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      for(int i = 0; i < matrix.GetLength(0); i++)
      {
        matrix[i, j] = rand.Next(leftRange, rightRange + 1);
      }
    }
return matrix;
 }