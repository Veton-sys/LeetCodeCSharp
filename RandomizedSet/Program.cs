namespace RandomizedSet
{
    public class Program
    {
        List<int> numbers = new List<int>();
        static void Main(string[] args)
        {

        }

        public bool Insert(int val)
        {
            if (numbers.Any(n => n == val)) return false;

            numbers.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (numbers.Any(n => n == val))
            {
                numbers.Remove(val);
                return true;
            }

            return false;
        }

        public int GetRandom()
        {
            Random r = new Random();

            return numbers.ElementAt(r.Next(numbers.Count));
        }
    }
}