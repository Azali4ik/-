int Akkerman(int N, int M)
{
    if (N == 0)
        return M + 1;
    else
        if ((N > 0) && (M == 0))
            return Akkerman(N - 1, 1);
        else
        {
            return Akkerman(N - 1, Akkerman(N, M - 1));
        }
}

Console.Write("Введите число N: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите число M: ");
int j = int.Parse(Console.ReadLine());
Console.WriteLine($"Функция Аккермана = {Akkerman(i, j)}");