using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] tablica = new string[4];

            tablica[0] = "w1";
            tablica[1] = "w2";
            tablica[2] = "w3";

            Console.ReadKey();
            */
            /* 
             Random generator = new Random();
             int[] x = new int[20];
             for (int i = 0; i < x.Length; i++)
             {
                 x[i] = generator.Next(1, 21);
                 Console.WriteLine(x[i]);
             }
             int temp;
             Console.WriteLine("Bubble sort: ");
             for (int i = 0; i < x.Length; i++)
             {
                 for(int j = i + 1;j < x.Length; j++)
                 {
                     if(x[i] > x[j])
                     {
                         temp = x[i];
                         x[i] = x[j];
                         x[j] = temp;
                     }
                 }
             }
             for (int i = 0; i < x.Length; i++)
             {
                 Console.WriteLine(x[i]);
             }
             Console.ReadKey();
         */

            Random generator = new Random();
            int[] x = new int[20];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = generator.Next(1, 21);
                Console.WriteLine(x[i]);
            }
            int temp;
            Console.WriteLine("Bubble sort: ");
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadKey();
        }
        
    }
}
