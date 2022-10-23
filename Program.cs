namespace Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.*/

            Console.WriteLine("Ex. 1:\r\n");

            Console.WriteLine("Let's check prime numbers between 1 - x.");
            Console.WriteLine("Enter x:");
            int x = int.Parse(Console.ReadLine());

            int counter = 0;

            Console.Write("List: ");

            for (int i = 2; i <= x; i++)
            {
                int checker = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        checker++;
                    }
                }
                if (checker == 1)
                {
                    Console.Write($"{i} ");
                    counter++;
                }
            }

            Console.WriteLine($"\r\n\nThere is {counter} prime numbers between 0 - {x}.");

            /* 2) Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
               zakresu 0 – 1000.*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 2:\r\n");
            Console.ReadKey();

            Console.Write(" List of even numbers between 0 - 1000: ");

            int a = 0;
            do
            {
                if (a % 2 == 0)
                {
                    Console.Write($"{a} ");
                }
                a++;
            } while (a <= 1000);

            Console.WriteLine();


            /* 3) Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie. */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 3:\r\n");
            Console.ReadKey();

            Console.WriteLine("Let's write Fibonacci Numbers between 1 - y.");
            Console.WriteLine("Enter y:");
            long y = long.Parse(Console.ReadLine());

            int fiboNminus2 = 0;
            int fiboNminus1 = 1;
            int fiboN = 0;

            Console.Write("List: 0 1 ");

            while (fiboN <= y)
            {
                fiboN = fiboNminus1 + fiboNminus2;
                if (fiboN > y)
                {
                    break;
                }
                Console.Write($"{fiboN} ");
                fiboNminus2 = fiboNminus1;
                fiboNminus1 = fiboN;
            }

            Console.WriteLine();

            /* 4) Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
               liczby w formie jak poniżej:
               1
               2 3
               4 5 6
               7 8 9 10*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 4:\r\n");
            Console.ReadKey();

            Console.WriteLine("Enter Pyramyd size:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int print = 0;

            for (int i = 1; print < p; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    print++;
                    Console.Write($"{print} ");
                    if (print == p)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            /* 5) Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 5:\r\n");
            Console.ReadKey();

            int power = 1;

            do
            {
                Console.WriteLine($"{power} cubed is {power * power * power}");
                power++;
            } while (power <= 10);

            Console.WriteLine("\r\nSecond method:\r\n");

            for (power = 1; power <= 10; power++)
            {
                Console.WriteLine($"{power} cubed is {power * power * power}");
            }











        }
        }
}