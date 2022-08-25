int size = 6;
int[] array = new int[size];
int max =0;
int min =0;
int raz =0;


for (int i = 0; i < array.Length; i++)
{
  
    array[i] = new Random().Next(1, 10);
    
    if(array[i] > max) 
    {
       max = array[i]; 
    }
    
    if( array[i] < min)
    {
        
        min = array[i];  
       
    }    
    if (array[i] == raz)
    {
       raz = max - min; 
    }
       


 Console.Write(array[i] + ", ");
 
 }
   Console.WriteLine();


Console.WriteLine($"Маскимальное число в массиве: {max }\n" +
                  $"Mинимальное  число в массиве: {min}\n" + 
                  $"Разнца между  максимальным и минимальным элементом массива: {raz}");