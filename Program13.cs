Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)

  if(number < 999)
 {
   int lastDigit = number % 10;
   Console.WriteLine(lastDigit);
 }

  if((number < 99))
{
 Console.WriteLine("Третего числа нет");
}
