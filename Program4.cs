Console.Write("Введите число M: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());

int Fibonacci(int n)
{
    if (n == 1) return a + b;
    if (n == 2) return (a + b) + b;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
    for (int i = 1; i < 10; i++)
    {
        Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    }