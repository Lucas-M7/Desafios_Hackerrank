int[] arr = [1, 1, 0, -1, -1];

int size = arr.Length;
int positive = 0, negative = 0, zero = 0;

foreach (int num in arr)
{
    if (num > 0)
        positive++;
    else if (num < 0)
        negative++;
    else
        zero++;
}

Console.WriteLine("{0:F6}", (double)positive / size);
Console.WriteLine("{0:F6}", (double)negative / size);
Console.WriteLine("{0:F6}", (double)zero / size);