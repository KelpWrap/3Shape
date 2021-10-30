class Fibonacci
{
    public int CalculateFib(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return CalculateFib(n - 1) + CalculateFib(n - 2);
        }
    }
}