namespace LenghtOfLastWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] gas = new int[3];
            gas[0] = 2;
            gas[1] = 3;
            gas[2] = 4;
            // gas[3] = 4;
            // gas[4] = 5;

            int[] cost = new int[3];
            cost[0] = 3;
            cost[1] = 4;
            cost[2] = 3;
            // gas[3] = 1;
            // gas[4] = 2;
            Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
        }

        public static int LengthOfLastWord(string s)
        {

            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words[words.Length-1].Length;

        }
    }
}
