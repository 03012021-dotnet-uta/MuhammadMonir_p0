using System;

namespace SweetNSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int countSweet = 0;
            int countSalty = 0;
            int countSweetNSalty = 0;
            int start = 1;
            int end = 1000;
            for (i = start; i <= end; i++)
            {
                // number divisible by 3 and 5 will
                // print 'Sweet' in place of the number
                if (i % 3 == 0)
                    {
                        Console.Write("Sweet\t");
                        countSweet++;
                    }

                // number divisible by 5 print 'Salty'
                // in place of the number
                if ((i % 5) == 0)
                    {
                        Console.Write("Salty\t");
                        countSalty++;
                    }

                // number divisible by 3 and 5, print 'SweetNSalty'  
                // in place of the number
                if ((i % 5 == 0) && (i % 3 == 0))
                    {
                        Console.Write("SweetNSalty\t");
                        countSweetNSalty++;
                    }

                else // print the number            
                    Console.Write("{0}\t", i);
                // after printing 10 numbers goto next line
                if (i%10 == 0)
                    Console.WriteLine("\n");

            }

            System.Console.WriteLine("\n\n\n******* Total Counts *********");
            System.Console.WriteLine("Sweet = {0} \nSalty = {1} \nSweetNSalty = {2}",
            countSweet, countSalty, countSweetNSalty);

        }
    }
}
