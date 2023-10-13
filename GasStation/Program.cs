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
            int startIndex = 0;
            int tank = 0;

            var totalGas = gas.Sum();
            var totalCost = cost.Sum();

            if (totalGas < totalCost) return -1;

            for (int i = 0; i < gas.Length; i++)
            {
                tank += gas[i] - cost[i];

                if (tank < 0)
                {
                    tank = 0;
                    startIndex = i + 1;
                }
            }

            return tank > 0 ? startIndex : -1;
        }
    }
}
