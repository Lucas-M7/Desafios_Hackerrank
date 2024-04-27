static void DiagonalDifference(List<List<int>> arr)
{
    int primary = 0;
    int second = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        primary += arr[i][i];
        second += arr[i][arr.Count - i - 1];
    }

    Console.WriteLine(primary - second);
}

DiagonalDifference([[10, 39, 5, 393, 29], [47, 5, 10, 58]]);