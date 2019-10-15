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
            //ExampleWhile();

            //CastExample();


            int[] sir = new int[] { (int)40.3, 3, 43, 4545, 564};

            int[] sir2 = new int[6];

            int[] sir3 = { (int)40.3, 3, 43, 4545, 564 };

            int val = sir3[3];


            int[] sir4 = new int[sir3.Length];


            for (int i = sir3.Length - 1; i >= 0; i--)
            {
                sir4[sir4.Length - i - 1] = sir3[i];
            }

            Array.Reverse(sir3);

            for (int i = 0; i < sir3.Length; i++)
            {
                Console.WriteLine(sir3[i]);
            }
            


            Console.ReadLine();
        }

        private static void CastExample()
        {
            int x = (int)40.5;

            double y = x;
        }

        private static void ExampleWhile()
        {
            int[] sir = new int[] { 0, 3, 7, 8, 8, 8 };

            int i = 0;

            while (i < sir.Length)
            {
                Console.WriteLine(sir[i]);
                i++;
            }
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

        private static void ExampleWhile2()
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
