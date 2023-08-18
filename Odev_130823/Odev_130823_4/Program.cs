static bool IsPerfectNum(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
        }
    }
    return sum == number;
}

for (int number = 1; number <= 1000; number++)
{
    if (IsPerfectNum(number))
    {
        Console.Write(number + " mükemmel sayıdır, çarpanları: ");
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}