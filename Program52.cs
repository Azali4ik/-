Console.WriteLine("Ввидите число М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


double rez = 0;
int[,] matr = FillMatrix(m, n, -10, 10);

PrintMatrix(matr);
void PrintMatrix(int[,] matrix)

{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
     
       
       Console.Write( matrix[i, j] + ", ");
         rez = (matrix[i, j] +n) / m ;
       
      }
      Console.WriteLine();
    }
}
Console.Write("Среднее арефм.: " + rez);

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
return matrix;
 }