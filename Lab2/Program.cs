namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 20));
                Console.Write("{0} ", chisla[i]);
            }
        }
    }
}
