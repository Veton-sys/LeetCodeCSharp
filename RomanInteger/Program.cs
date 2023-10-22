namespace RomanInteger
{
    public class Program
    {

        public static Dictionary<char, int> romanNumerals = new Dictionary<char, int>()
        {
            {'I',  1},
            {'V',  5},
            {'X',  10},
            {'L',  50},
            {'C',  100},
            {'D',  500},
            {'M',  1000},
        };

        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public static int RomanToInt(string s)
        {
            int convertedNum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1) convertedNum += romanNumerals[s[i]];
                else
                {
                    string comb = s[i].ToString() + s[i + 1].ToString();
                    switch (comb)
                    {
                        case "IV": convertedNum += 4; i++; break;
                        case "IX": convertedNum += 9; i++; break;
                        case "XL": convertedNum += 40; i++; break;
                        case "XC": convertedNum += 90; i++; break;
                        case "CD": convertedNum += 400; i++; break;
                        case "CM": convertedNum += 900; i++; break;
                        default: convertedNum += romanNumerals[s[i]]; break;
                    }
                }

            }

            return convertedNum;
        }

    }
}