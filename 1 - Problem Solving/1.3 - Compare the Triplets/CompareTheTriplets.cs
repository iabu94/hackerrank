class CompareTheTriplets
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var points = new List<int>() { 0, 0 };
        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                points[0] = points[0] + 1;
            }
            else if (a[i] < b[i])
            {
                points[1] = points[1] + 1;
            }
        }
        return points;
    }

}