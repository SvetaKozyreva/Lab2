using System.Numerics;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Example 1

            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(1, 20));
                Console.Write("{0} ", chisla[i]);
            }

            //Example 2

            int mx = chisla[0];
            int nmx = 0;
            for (int i = 1; i < chisla.Count; i++)
            {
                if (chisla[i] > mx)
                {
                    mx = chisla[i];
                    nmx = i;
                }
            }
            Console.WriteLine("\n{0} {1}", mx, nmx);

            //Example 3

            Console.WriteLine("Example 3");
            int x = Convert.ToInt32(Console.ReadLine());
            chisla.Remove(x);
            for (int i = 0;i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }

            //Example 4

            Console.WriteLine("\nExample 4");
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = chisla.Count - 1; i>= 0; i--)
            {
                if (chisla[i] == y) chisla.Remove(y);
            }
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }

            //Example 5

            Console.WriteLine("\nExample 5");
            int k = Convert.ToInt32(Console.ReadLine());
            chisla.RemoveAt(k);
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }

            //Example 6

            Console.WriteLine("\nExample 6") ;
            for (int i = chisla.Count-1; i>=0; i--)
            {
                if(i%2== 0) chisla.RemoveAt(i);
            }
            for (int i = 0; i<chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }

            //Example 7

            Console.WriteLine("\nExample 7 \nВведіть індекс");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть число");
            int e = Convert.ToInt32(Console.ReadLine());
            chisla.Insert(l, e);
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }

            //Example 8

            Console.WriteLine("\nExample 8 \nВведіть число");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = chisla.Count - 1; i>=0; i--)
            {
                if (chisla[i] % 2 == 0) chisla.Insert(i, b);
            }
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }

        }
    }
}
