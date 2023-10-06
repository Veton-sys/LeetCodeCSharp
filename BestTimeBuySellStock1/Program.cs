namespace BestTimeBuySellStock1
{
    public class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[6];
            nums[0] = 7;
            nums[1] = 1;
            nums[2] = 5;
            nums[3] = 3;
            nums[4] = 6;
            nums[5] = 4;
            Console.WriteLine(MaxProfit(nums));
        }

        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int price = prices[i];
                if (price > prices[i + 1])
                {
                    continue;
                }

                int k = prices.Length - 1 - i;
                while (k > 0)
                {
                    int currentMax = prices[prices.Length - k] - price;
                    k--;
                    if (currentMax < max) continue;
                    else max = currentMax;
                }

            }

            return max;
        }
    }
}