int num  = ReadInt("Введите число: ");
int i = 1;

while(i <= num)
{
    Console.Write(Cube(i++) + ",");
}


int Cube(int a)
{
    return a * a * a;
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}