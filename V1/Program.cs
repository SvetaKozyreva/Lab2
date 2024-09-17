namespace V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Task 1

            Console.WriteLine("Task 1");
            Random o = new Random();
            List<int> chisla = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla.Add(o.Next(5, 16));
                Console.Write("{0} ", chisla[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < chisla.Count; i++)
            {
                if (chisla[i] % 2 == 0)
                {
                    chisla.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < chisla.Count; i++)
            {
                Console.Write("{0} ", chisla[i]);
            }

            //Task 2
            Console.WriteLine("\nTask 2");
            Random o2 = new Random();
            List<int> chisla2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                chisla2.Add(o2.Next(-5, 6));
                Console.Write("{0} ", chisla2[i]);
            }

            Console.WriteLine();
            for (int i = chisla2.Count - 1; i >= 0; i--)
            {
                if (chisla2[i] < 0) chisla2.Insert(i, 11);
            }
            for (int i = 0; i < chisla2.Count; i++)
            {
                Console.Write("{0} ", chisla2[i]);
            }

            //Task 3
            Console.WriteLine("\nTask 3");
            Random o3 = new Random();
            List<int> chisla3 = new List<int>();
            List<int> chislaP = new List<int>();
            List<int> chislaN = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                chisla3.Add(o3.Next(-10, 11));
                Console.Write("{0} ", chisla3[i]);
            }

            for (int i = 0; i < chisla3.Count; i++)
            {
                if (chisla3[i] < 0)
                {
                    chislaN.Add(chisla3[i]);
                }
                else if (chisla3[i] > 0)
                {
                    chislaP.Add(chisla3[i]);
                }
            }

            Console.WriteLine("\nПозитивні:");
            for (int i = 0; i < chislaP.Count; i++)
            {
                Console.Write("{0} ", chislaP[i]);
            }
            Console.WriteLine("\nНегативні:");
            for (int i = 0; i < chislaN.Count; i++)
            {
                Console.Write("{0} ", chislaN[i]);
            }



        }
    }
}
