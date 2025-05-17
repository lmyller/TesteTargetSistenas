
Fibonacci();

void Fibonacci()
{
    int n = 10,
        first = 0,
        second = 1,
        temp;

    for (int i = 1; i < n; i++)
    {
        Console.Write(first + " ");

        temp = first;
        first = second;
        second = temp + second;

    }
}