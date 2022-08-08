Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третие число: ");
int numberС = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
   Console.WriteLine("Первое число " + numberA + " больше чем второе: " + numberB);
}
else;
if (numberA < numberB)
{
  Console.WriteLine("Второе число " + numberB + " больше чем первое: " + numberA);
}
else;
if (numberA > numberС)
{
   Console.WriteLine("Первое число " + numberA + " больше чем третие: " + numberС);
}
else;
if (numberA < numberС)
{
  Console.WriteLine("Третие число " + numberС + " больше чем первое: " + numberA);
}
else;
if (numberB > numberС)
{
   Console.WriteLine("Второе число  " + numberB + " больше чем третие: " + numberС);
}
else;
if (numberB < numberС)
{
  Console.WriteLine("Третье число " + numberС + " больше чем второе: " + numberB);
}
else;