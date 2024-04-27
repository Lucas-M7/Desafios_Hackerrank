static void CompareTriplets(List<int> a, List<int> b)
{
    List<int> result = [0, 0];

    for (int i = 0; i < 3; i++)
    {
        if (a[i] > b[i])
        {
            result[0] += 1;
        }
        else if (a[i] < b[i])
        {
            result[1] += 1;
        }
    }

    Console.WriteLine(result);
}

CompareTriplets([31, 314, 522], [313, 424, 41]);