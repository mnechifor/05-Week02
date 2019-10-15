using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ora1();

            Console.ReadLine();
        }

        private static void Ora1()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int k = 7;

            int[] sir = new int[] { 0, 3, 7, 8, 8, 8 };
            //string litere = "abcdef";
            // char[] litere = new char[] { 'a', 'b', 'c' };

            //ExampleWhile();

            ExampleForeach(sir);

            ExampleFor(sir);
        }

        private static void ExampleFor(int[] sir)
        {
            for (int i = 0; i < sir.Length; i = i + 1)
            {
                if (i % 2 != 0)
                {

                }

                int element = sir[i];
                Console.WriteLine(element);
            }
        }

        private static void ExampleForeach(int[] sir)
        {
            foreach (int element in sir)
            {
                if (element == 7)
                    break;

                Console.WriteLine(element);

            }
        }

        private static void ExampleWhile()
        {
            int nr = 0;

            while (nr < 1000)
            {
                Console.WriteLine("Introduceti nr");
                nr = int.Parse(Console.ReadLine());
            }
        }
    }
}
