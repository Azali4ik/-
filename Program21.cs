int x1 = ReadInt("Введите Х точки А: ");
int y1 = ReadInt("Введите Y точки А: ");
int z1 = ReadInt("Введите Z точки А: ");

int x2 = ReadInt("Введите Х точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");


int lengthX = x2 - x1; 
int lengthY = y2 - y1;
int lengthZ = z2 - z1;

double distance = Math.Sqrt(lengthX * lengthX + lengthY * lengthY + lengthZ * lengthZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}