class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        var tallest = candles.Max();
        int count = 0;
        var size = candles.Count;
        var first = candles[0];

       foreach(int candle in candles)
        {
            if (candle == tallest)
            {
                count++;
            }
        }
       
       /*
       var max = candles[0];

       for(int i = 1; i < size; i++)
        {
            if(candles[i] > max)
            {

                max = candles[i];
            }
        }

        for(int i = 0; i < size; i++)
        {
            if(max == candles[i])
            {
                count++;
            }
        }
       */

        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        Console.WriteLine(result);
    }
}
