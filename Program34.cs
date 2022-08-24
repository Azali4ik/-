int size = 10;
int[] numbers = new int[size];
int count = 0; 
for (int i = 1; i < numbers.Length; i++)
{
  
    numbers[i] = new Random().Next(99, 1000);
     if (numbers[i] % 2 ==0)
    {
      count++;
    } 
     Console.Write(numbers[i] + ", ");
     

 }
   Console.WriteLine();
   Console.Write("количество четныйх чисел в данном массиве равно: " + count);