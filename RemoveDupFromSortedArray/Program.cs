namespace RemoveDupFromSortedArray
{
    public class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 1;
            nums[1] = 1;
            nums[2] = 2;
            RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int counter = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[counter] != nums[i])
                {
                    counter++;
                    nums[counter] = nums[i];
                }
            }


            return counter+1;
        }
    }
}