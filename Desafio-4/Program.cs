static void AVeryBigSum(List<long> myAr)
{
    long result = 0;

    for (int i = 0; i < myAr.Count; i++)
    {
        result += myAr[i];
    }
    Console.WriteLine(result);
}

AVeryBigSum([5, 1000000000000000000]);