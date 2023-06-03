// See https://aka.ms/new-console-template for more information
GetMultiplesof3and5(Convert.ToInt32(Console.ReadLine()));

void GetMultiplesof3and5(int range)
{
    double sum = 0;
    for (int i = 0; i < range; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            sum += i;
        }
    }

    Console.WriteLine(sum);
}

