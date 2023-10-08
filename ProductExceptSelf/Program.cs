using System.Security.Cryptography;

namespace ProductExceptSelf
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            Console.WriteLine(ProductExceptSelf(nums));
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] productCalculated = new int[n];

            // Initialize the product of the left product
            int leftProduct = 1;
            for (int i = 0; i < n; i++)
            {
                productCalculated[i] = leftProduct;

                // The order is important, do this calculaton later to
                // Exclude the current value (will be assigned next)
                leftProduct *= nums[i];
            }

            // Initialize the right product and iterate backwards
            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                // Var already holds left value
                productCalculated[i] *= rightProduct;

                // The order is important, same as left
                rightProduct *= nums[i];
            }
            return productCalculated;
        }
    }
}
