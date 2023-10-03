namespace RotateArray
{
    public class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[7];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;
            nums[5] = 6;
            nums[6] = 7;
            Rotate(nums, 3);
        }

        public static void Rotate(int[] nums, int k)
        {
            int temp = nums[0];
            while (k > 0)
            {
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    if (i == nums.Length - 1)
                    {
                        temp = nums[i];
                    }
                    nums[i] = nums[i - 1];
                }
                nums[0] = temp;
                k--;
            }
        }
    }
}