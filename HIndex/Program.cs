namespace HIndex
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] citations = new int[5];
            citations[0] = 3;
            citations[1] = 0;
            citations[2] = 6;
            citations[3] = 1;
            citations[4] = 5;
            HIndex(citations);
        }

        public static int HIndex(int[] citations)
        {
            Array.Sort(citations);
            int h = citations.Length;
            if (citations.Any(n => n < h)) h--;


            int j = 0;
            for (int i = citations.Length - 1; i >= 0; i--)
            {
                if (citations[i] >= h)
                {
                    j++;
                    continue;
                }

                if (j >= h)
                {
                    return h;
                }
                else
                {
                    h--;
                    j = 0;
                    i = citations.Length;
                }
            }

            return h;
        }

    }
}