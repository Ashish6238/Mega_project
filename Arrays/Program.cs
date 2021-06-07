using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = new int[4];
             arr[0]= 2;
             arr[1]= 3;
             arr[2]= 4;
            arr[3] = 6;*/

           

            int[] arr = { 1, 2, 3, 4, 5};

           // int[] arr = new int[3] { 12, 43, 56 };

            Console.WriteLine("Size of array:{0}", arr.Length);
            
            //input array
            for (int i = 0; i < arr.Length; i++)
                  arr[i]= Convert.ToInt32( Console.ReadLine());
            //Print array
            Console.WriteLine("Initial array:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("arr[{0}]:{1}",i,arr[i]);

            //rev array
            Console.WriteLine("Reverese array:");
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.WriteLine("arr[{0}]:{1}",i,arr[i]);

            //sorting array
            Console.WriteLine("Ascending sort:");
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                
                }
            Console.WriteLine("After Ascending sort:");
            for (int i = 0; i < arr.Length; i++)
            
               Console.WriteLine("arr[{0}]:{1}", i, arr[i]);

            Console.WriteLine("Descending sort:");
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {

                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            Console.WriteLine("After Descending sort:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("arr[{0}]:{1}", i, arr[i]);
        }
    }
}
