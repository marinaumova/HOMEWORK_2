Console.Write("Введите неотрицательное число m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Ack(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ack(n - 1, 1);
    }
    else
    {
        return Ack(n - 1, Ack(n, m - 1));
    }
}
int result = Ack(n, m);
Console.Write($"Ack({m}, {n}) = {result}");