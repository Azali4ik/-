int size = 10;
int[] numbers = new int[size];
int count = 0; 
for (int i = 1; i < numbers.Length; i++)
{
  
    numbers[i] = new Random().Next(-99, 100);
     if (numbers[i] % 2 == 1)
    {
      
      count += numbers[i];
    } 
     Console.Write(numbers[i] + ", ");
     

 }
   Console.WriteLine();
   Console.Write("Сумма нечетных чисел массива равна: " + count);