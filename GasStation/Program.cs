using System.Globalization;

namespace GasStation
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
            Console.WriteLine(CanCompleteCircuit(gas, cost));
        }

        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int startIndex = -1;
            int tank = 0;
            int n = gas.Length;
            int trigger = 0;
            for (int i = 0; i < gas.Length; i++)
            {

                startIndex = i;
                for (int j = i; j <= n; j++)
                {
                    trigger++;
                    if(trigger == n+1) break;
                    if (j == n)
                    {
                        j = 0;
                    }

                    tank += gas[j];
                    if (tank < cost[j])
                    {
                        startIndex = -1;
                        tank = 0;
                        trigger = 0;
                        break;
                    }
                    else
                    {
                        tank -= cost[j];
                    }
                }
                if(startIndex != -1) break;

            }

            return startIndex;
        }
    }
}
