using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
         


                MethodA();
                Console.WriteLine();
            }
            public void MethodA()
            {
                int i;
                while (Peanut())
                {
                    Console.WriteLine("i is{0},"i);
                    if (i > 10)
                    {
                        return;
                    }
                }

            }
        }

        public static bool Peanut()
        {
            i++;
            return true;
        }

    }