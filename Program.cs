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

            /* 6) Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
               1 + ½ + 1/3 + ¼ itd..*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 6:\r\n");
            Console.ReadKey();

            double sum = 0;
            int maxValue = 20;

            for (double i = 1; i <= maxValue; i++)
            {
                sum = sum + (1 / i);
            }

            Console.WriteLine($"Sum of the fractions 1 + 1/2 + 1/3 + ... + 1/{maxValue} equals: {sum}");

            /* 7) Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
               przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
                  *
                 ***
                *****
               *******
              *********
               *******
                *****
                 ***
                  *.*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 7:\r\n");
            Console.ReadKey();

            Console.WriteLine("Enter shorter diagonal of the diamond:");
            
            int diameter = int.Parse(Console.ReadLine());

            if (diameter % 2 == 0)
            {
                // romb dla parzystej przekątnej
                for (int i = 0; i <= diameter; i++)
                {
                    for (int j = diameter; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                for (int i = diameter - 1; i > 0; i--)
                {
                    for (int j = diameter; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                // romb dla nieparzystej przekątnej
                for (int i = 1; i <= diameter; i = i + 2)
                {
                    for (int j = diameter; j > i; j = j - 2)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = diameter - 2; i > 0; i = i - 2)
                {
                    for (int j = diameter; j > i; j = j - 2)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }

            /* 8) Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
               Testowe dane:
               Abcdefg
               Rezultat
               Gfedcba
               */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 8:\r\n");
            Console.ReadKey();

            Console.WriteLine("Enter any string:");

            string str = Console.ReadLine();
            int len = str.Length;

            for (int i = len-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }

            /* 9) Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 9:\r\n");
            Console.ReadKey();

            Console.WriteLine("Enter decimal number to convert for binary number:");

            int nmbr = int.Parse(Console.ReadLine());
            string s = "";

            if (nmbr == 0)
            {
                Console.WriteLine("The number 0 in a binary system is 0");
            }
            else
            {
                for (int i = nmbr; i > 0;)
                {
                    if (i % 2 == 0)
                    {
                        s += "0";
                        i = i / 2;
                    }
                    else
                    {
                        s += "1";
                        i = (i - 1) / 2;
                    }
                }

                Console.Write($"The number {nmbr} in a binary system is ");
                for (int i = s.Length; i > 0; i--)
                {
                    Console.Write(s[i - 1]);
                }
                Console.WriteLine(".");
            }

            /* 10) Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.*/

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 10:\r\n");
            Console.ReadKey();

            Console.WriteLine("Enter 2 numbers to find least common multiple:");
            Console.WriteLine("Enter first number:");
            int numFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int numSecond = int.Parse(Console.ReadLine());

            int multiplication = numFirst * numSecond;
            int lcm1 = 0;
            int lcm2 = 0;

            for (int i = multiplication; i > 0; i -= numFirst)
            {
                if (i % numSecond == 0)
                {
                    lcm1 = i;
                }
            }
            for (int i = multiplication; i > 0; i -= numSecond)
            {
                if (i % numFirst == 0)
                {
                    lcm2 = i;
                }
            }

            Console.Write($"Least common multiple for {numFirst} and {numSecond} is -> ");

            if (lcm1 >= lcm2)
            {
                if (lcm1 <= multiplication)
                {
                    Console.Write(lcm1);
                }
                else
                {
                    Console.Write(multiplication);
                }
            }
            else
            {
                if (lcm2 <= multiplication)
                {
                    Console.Write(lcm2);
                }
                else
                {
                    Console.Write(multiplication);
                }
            }
            Console.Write(".");
            Console.WriteLine();
        }
    }
}