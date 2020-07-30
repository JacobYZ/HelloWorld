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
                        if (n % 2 == 0)
                        {
                            Console.WriteLine(n + " % 2 == 0, n = " + n + " / 2");
                            n /= 2;
                            //                        Console.Write("n = " + n);
                        }
                        else
                        {
                            Console.WriteLine(n + " % 2 != 0, n = " + n + " * 3 + 1");
                            n = n * 3 + 1;
                        }
                        Console.WriteLine("n = " + n);
                    }
                    else Console.Write(s + " is not a positive integer. Please enter again: ");
                }
            } while (b == false || n <= 0);
        }
    }
}

