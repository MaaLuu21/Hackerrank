class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        int size = arr.Count;

        long sum = arr.Select(x => (long)x).Sum();

        /*
        long sum = 0;
        for (int i = 0; i < size; i++)
        {
            soma += arr[i];
        }
        */
        long min = arr.Min();

        /*
        long min = arr[0];
        for (int i = 1; i < size; i++)
        {
            if (arr[i] < arr[0])
            {
                min = arr[i];
            }
        }
        */

        long max = arr.Max();

        /*
        long max = arr[0];
        for (int i = 1; i < size; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        */

        long maxSum = sum - min;
        long minSum = sum - max;

        Console.Write(minSum + " " + maxSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}