namespace JumpGame
{
    public class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[7];
            nums[0] = 1;
            nums[1] = 1;
            nums[2] = 2;
            nums[3] = 2;
            nums[4] = 0;
            nums[5] = 1;
            nums[6] = 1;
            Console.WriteLine(CanJump(nums));
        }

        public static bool CanJump(int[] nums)
        {
            int[] temp;
            int j = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max = 0;
                temp = (int[])nums.Clone();
                if (nums.Length <= 1) return true;
                else if (nums.Length - 1 - i <= nums[i]) return true;
                else if (nums[i] == 0) return false;
                else
                {
                    Array.Copy(nums, i + 1, temp, 0, nums[i]);
                    Array.Resize(ref temp, nums[i]);
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if(max <= temp[k]) 
                        {
                            max = temp[k];
                            j = k;
                        }
                    }
                    i += j;
                }
            }

            return false;
        }
    }
}