using System;

namespace sum_of_even_number
{
    class app
    {
        public static void Main()
        {
            int a = 2;
            int sum = 0;

            while (a <= 100)
            {
                sum = sum + a;
                a = a + 2;
            }

            Console.WriteLine(sum);
        }
    }
}