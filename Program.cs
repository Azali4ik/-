void PrintNumber(int n)
{
    Console.Write(n + " ");
    n--;
    if(n == 0) return;
    PrintNumber(n);
}
int N = 20;
PrintNumber(N);