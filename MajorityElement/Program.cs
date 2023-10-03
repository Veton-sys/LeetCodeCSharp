namespace MajorityElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 3;
            nums[1] = 2;
            nums[2] = 3;
            MajorityElement(nums);
        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> majorityElem = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!majorityElem.ContainsKey(num))
                {
                    majorityElem.Add(num, 1);
                }
                else
                {
                    majorityElem[num]++;
                }
            }


            return majorityElem.MaxBy(k => k.Value).Key;
        }

    }
}