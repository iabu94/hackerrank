class DiagonalDifference
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int primary = 0;
        int secondary = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            primary += arr[i][i];
            secondary += arr[i][arr.Count - 1 - i];
        }

        return Math.Abs(primary - secondary);
    }

}