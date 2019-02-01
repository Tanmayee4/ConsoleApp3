using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    class Program
    {
        public static void Main()
        {
            int ch = 1;
            Console.WriteLine("The program contains the following functions");
            Console.WriteLine("1.Prime numbers\n2.Triangle\n3.Decimal to Binary\n4.Binary to Decimal\n5.Frequency\n6.Series");
            while (ch != 7)
            {
                Console.WriteLine("\nChoose the number of function you want run (1 to 6)");
                string inp = Console.ReadLine();
                ch = Convert.ToInt32(inp);
                switch (ch)  //switch case for executing all the functions
                {
                    case 1:
                        int x = 0, y = 0;
                        pn(x, y);
                        break;

                    case 2:
                        triangle();
                        break;

                    case 3:
                        long num = 0;
                        long r2 = dectobin(num);
                        Console.WriteLine("The decimal number is :" + r2);
                        Console.WriteLine(r2);
                        Console.ReadKey();
                        break;

                    case 4:
                        long n3 = 0;
                        long r3 = bintodec(n3);
                        break;

                    case 5:
                        Console.WriteLine("Enter the Number of terms for Series: ");
                        string input = Console.ReadLine();
                        double n = double.Parse(input);
                        double r1 = gets(n);
                        Console.WriteLine("The sum of the series is: " + r1);
                        Console.ReadKey();
                        break;

                    case 6:
                        freq();
                        break;

                }//switch
            }//while
        }//main function

        static void pn(int x, int y)
        {
            try
            {
                int n, m;
                Console.WriteLine("Enter the starting number");
                string input = Console.ReadLine();
                m = Convert.ToInt32(input);
                Console.WriteLine("Enter the ending number");
                string inp = Console.ReadLine();
                n = Convert.ToInt32(inp);
                Console.WriteLine("The prime numbers are:");
                for (x = m; x <= n; x++)// loop is numerator
                {
                    int num = 0;
                    for (y = 1; y <= n; y++)// loop is denominator
                    {
                        if (x % y == 0) // if mod is 0, number is not prime 
                            num++;
                    }
                    if (num == 2)
                        Console.WriteLine(x);
                }
            }
            catch
            {
                Console.WriteLine("Exception occurred");
            }
            Console.ReadKey();
        }//prime numbers

        static void triangle()
        {
            int n, i, j, k;
            try
            {
                Console.WriteLine("Enter number of levels-n");
                string inp = Console.ReadLine();
                n = Convert.ToInt32(inp);
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= (n - i); j++)//loop for spaces
                        Console.Write(" ");
                    for (k = 1; k < i * 2; k++)//loop for printing asterix mark
                        Console.Write("*");
                    Console.WriteLine();// newline
                }
            }
            catch
            {
                Console.WriteLine("Exception occurred");
            }
            Console.ReadKey();
        }// triangle

        public static long dectobin(long num)
        {
            try
            {
                string res = "";
                Console.WriteLine("Enter the decimal number");
                string inp = Console.ReadLine();
                num = Convert.ToInt32(inp);
                while (num > 1)
                {
                    long r = num % 2; //base 2, mod 2
                    res = Convert.ToString(r) + res;
                    num /= 2;
                }
                res = Convert.ToString(num) + res;
                return Convert.ToInt64(res);
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }
            return 0;
        }// decimal to binary

        public static long bintodec(long n)
        {
            try
            {
                int num, bin, a = 0, b = 1, rem;
                Console.Write("Enter a binary number\n");
                num = int.Parse(Console.ReadLine());
                bin = num;
                while (num > 0)
                {
                    rem = num % 10;// obtain remainder by mod 10
                    a = a + rem * b;
                    num = num / 10; // divide the quotient by 10, store the value
                    b = b * 2;
                }
                Console.WriteLine("The decimal number is- ");
                Console.Write(a); // print output
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }
            return 0;
        }//binary to decimal

        public static double gets(double n)
        {
            try
            {
                int i;
                double even = 0, odd = 0, output = 0;
                for (i = 1; i <= n; i = i + 2)// loop for even terms
                {
                    even = fact(i) / (i + 1);
                }
                for (i = 2; i <= n; i = i + 2)// loop for odd terms
                {
                    odd = fact(i) / (i + 1);
                }// call factorial function 
                output = even - odd; // computing output
                return output;
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }
            return 0;
        }

        // function for computing factorial value 
        static double fact(int n)
        {
            try
            {
                int f = 1, i;
                for (i = 1; i <= n; i++)
                {
                    f = (f * i);// factorial calculation
                }
                return f;
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }
            return 0;
        }

        static void freq()
        {
            try
            {
                int[] array = new int[100];// input array
                int[] f = new int[100];// array for printing frequency
                int n, i, j, c;
                Console.Write("Enter number of elements to be stored - ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the elements ", n);// user entered array elements 
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);// read elements 
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    f[i] = -1;
                }
                for (i = 0; i < n; i++)
                {
                    c = 1;
                    for (j = i + 1; j < n; j++)
                    {
                        if (array[i] == array[j])// compare numbers
                        {
                            c++;
                            f[j] = 0;
                        }
                    }
                    if (f[i] != 0)// check for count
                    {
                        f[i] = c;
                    }
                }
                for (i = 0; i < n; i++)
                {
                    if (f[i] != 0)
                    {
                        Console.Write("Element {0} occurs {1} times\n", array[i], f[i]);
                    }// print elements 
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ëxception occured");
            }
        }// frequency

    }// class

}// end of program
