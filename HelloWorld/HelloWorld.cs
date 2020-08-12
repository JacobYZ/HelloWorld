using System;

namespace HelloWorld
{
    class Reading3
    {
        static void Main(string[] args)
        {
            string s;
            int n;
            bool b;
            Console.Write("Please enter a positive integer n: ");
            do {                
                s = Console.ReadLine();
                b = Int32.TryParse(s, out n);
                {
                    if (b && n > 0)
                    {
                        while (n != 1)
                        {
                            int t = n;
                            if (n % 2 == 0)
                            {
                                n /= 2;
                                Console.WriteLine(t + " % 2 == 0, n = " + t + " / 2 = " + n);
                                //Console.Write("n = " + n);
                            }
                            else
                            {
                                n = n * 3 + 1;
                                Console.WriteLine(t + " % 2 != 0, n = " + t + " * 3 + 1 = " +n);
                            }
                        }
                        Console.WriteLine("The final value of n is " + n);
                    }
                    else Console.Write(s + " is not a positive integer. Please enter again: ");
                }
            } while (b == false || n <= 0);
        }
    }
}

