// STAIRCASE

Console.WriteLine("Digite um número entre 1 e 10.");
int n = int.Parse(Console.ReadLine());

if (n > 0 || n < 11)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j < n - i; j++)
        {
            Console.Write(' ');
        }
        for (int k = 0; k < i; k++)
        {
            Console.Write('#');
        }

        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("O número deve ser entre 1 e 10.");
}