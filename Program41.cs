Console.Write("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:");
int numC = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:");
int numD = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:");
int numE = Convert.ToInt32(Console.ReadLine());
 int count =0;

if(numA > 0 && numB > 0 &&  numC > 0 &&  numD > 0 &&  numE > 0)
{
   count = 5;
}

Console.WriteLine("Количество положительных чисел:" + count);