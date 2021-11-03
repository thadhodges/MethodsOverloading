using System;

namespace MethodsOverloading
{
    class Program
    {

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static string Add(int x, int y, bool z)
        {
            int sum = x + y;
            if (z && sum > 1)
            {
                return $"{sum} dollars";
            }
            {
                if (sum == 1)
                    {
                    return $"{sum} dollar";
                    }
                
                    {
                        return "the bool is false";
                    }
                
            }
            
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add (5, 5));
            Console.WriteLine();
            Console.WriteLine(Add (4.56, 8.34));
            Console.WriteLine();
            Console.WriteLine(Add (4, 6, true));
            Console.WriteLine();
            Console.WriteLine(Add(2, 7, false));
            Console.WriteLine();
            Console.WriteLine(Add(0, 1, true));
        }
    }
}
