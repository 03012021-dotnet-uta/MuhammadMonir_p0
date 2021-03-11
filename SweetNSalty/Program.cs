using System;

namespace SweetNSalty
{
    public class Program
    {
        static int countSweet = 0;
        static int countSalty = 0;
        static int countSweetNSalty = 0;

        static void Main(string[] args)
        {
            int i;

            int start = 1;
            int end = 1000;
            for (i = start; i <= end; i++)
            {
                // number divisible by 3 and 5 will
                // print 'Sweet' in place of the number
                Console.Write(MySweetNSalty(i) + "\t");
                if (i % 10 == 0)
                    Console.Write("\n");

            }

            System.Console.WriteLine("\n\n\n******* Total Counts *********");
            System.Console.WriteLine("Sweet = {0} \nSalty = {1} \nSweetNSalty = {2}",
            countSweet, countSalty, countSweetNSalty);

        }

        public static string MySweetNSalty(int i)
        {
            if ((i % 5 == 0) && (i % 3 == 0))
            {

                countSweetNSalty++;
                return "SweetNSalty";
            }
            if (i % 3 == 0)
            {
                //  Console.Write("Sweet\t");
                countSweet++;
                return "Sweet";
            }

            // number divisible by 5 print 'Salty'
            // in place of the number
            if ((i % 5) == 0)
            {
                //Console.Write("Salty\t");
                countSalty++;
                return "Salty";
            }

            // number divisible by 3 and 5, print 'SweetNSalty'  
            // in place of the number


            else // print the number            
                return i.ToString();
            // after printing 10 numbers goto next line


        }
    }
}
