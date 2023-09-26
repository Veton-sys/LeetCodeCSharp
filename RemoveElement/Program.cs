namespace RemoveElement
{
    public class Program
    {

        static void Main(string[] args)
        {
        }

        public int RemoveElement(int[] nums, int val)
        {
            int p = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = 999;
                    p++;
                }
            }

            Array.Sort(nums, (i, j) => i.CompareTo(j));
            Array.Resize(ref nums, nums.Length - p);

            return nums.Length;
        }
    }
}