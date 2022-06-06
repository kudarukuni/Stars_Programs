static void Main(string[] args)
        {
            int i, j;
            int MAX = 10;
 
            for (i = 0; i < MAX; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }