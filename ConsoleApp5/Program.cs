using System;

namespace ConsoleApp5
{
    class Program
    {
        int i;
        static void Main(string[] args)
        {



            MethodA();
        }
        public static void MethodA()
        {
            while (Peanut())
            {

                Console.WriteLine(" i is {0}", i);
                if (i > 10)
                {
                    return;
                }

            }
        }

        public static bool Peanut()
        {
            i++;
            return true;
        }
    }
}