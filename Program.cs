using System;
using System.Collections.Generic;
using System.Linq;


namespace queuesharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string ch = "1";
            while (ch == "1")
            {
                Console.Write("enter 1 to start, 0 to exit >");
                ch = Console.ReadLine();
                switch (ch)
                {
                    case ("0"):
                        break;
                    case ("1"):
                        {
                            Random rnd = new Random();

                            Queue<int> output=new Queue<int>();

                            int[] dictionary = new int[35];

                            Console.Write($"\nsourse massive > ");

                            for (int i = 0; i <= 34; i++)
                            {
                                dictionary[i] = rnd.Next(1, 15);
                                Console.Write($"{dictionary[i]} ");
                            }

                            //and now the fun part - clearing duplicates in microclusters

                            for (int i = 34; i > 0; i--)
                                if (dictionary[i] == dictionary[i - 1])
                                    dictionary[i] = 0;

                            for (int i = 0; i < 35; i++)
                                if (dictionary[i] != 0)
                                    output.Enqueue(dictionary[i]);

                            Console.Write("\n\nafter cleanup > ");

                            while (output.Count()!=0)
                            {
                                int val = output.Dequeue();
                                Console.Write($"{val} ");
                            }

                            Console.WriteLine("\n");
                            continue;
                        }
                    default:
                        {
                            Console.WriteLine("\nincorrect input\n");
                            ch = "1";
                            continue;
                        }

                }

            }
        }
    }
}
