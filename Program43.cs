 
Console.Write("Введите число b1:");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k1 :");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2 :");
double b2  = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k2 :");
double k2= Convert.ToInt32(Console.ReadLine());

double y1 = 0;
double y2 = 0;
double x = 0;

if ( x == 0) 
{
  y1 = k1 * x + b1;
  
  x = (b2-b1)/(k2 - k1);
  x=(b2-b1)/(k1-k2); 
  y1= k1 *(b2-b1)/(k1-k2)+b1;


   y2 = k1 * x + b1;
  
  x = (b2-b1)/(k2 - k1);
  x=(b2-b1)/(k1-k2); 
  y2= k1 *(b2-b1)/(k1-k2)+b1;


Console.Write(y1 + ", ");
Console.Write(y2);
}
