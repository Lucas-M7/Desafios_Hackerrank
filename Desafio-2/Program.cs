static int SimpleArraySum(List<int> ar)
{
    int sum = 0;

    for (int i = 0; i < ar.Count; i++)
    {
        sum += ar[i];
    }

    return sum;
}

Console.WriteLine(SimpleArraySum([4, 4, 4, 4]));