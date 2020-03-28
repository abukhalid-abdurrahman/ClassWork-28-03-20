using System;

namespace taskFor7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5, B = 11, c = 0;
            for(int i = A; i <= B; i++)
            {
                c += i;
            }
            Console.WriteLine(c);
        }
    }
}
