using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Main(string[] args)
        {
        }
        public static void inputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static int FindMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static int FindMax(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void MinandMax(int[] array)
        {
            Console.WriteLine("the biggest number is", FindMin(array));
            Console.WriteLine("the smallest number is", FindMax(array));
        }
        static void ChangUp(string str1)
        {
            int chage = 0;
            string UP = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int x = 97; x <= 122; x++)
                {
                    if (str1[i] == x)
                    {
                        chage = x - 32;
                        UP += (char)chage;
                    }
                }
            }
            Console.Write(UP);
            Console.WriteLine();
        }
        static void ChangLow(string str1)
        {
            int chage = 0;
            string LOW = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int x = 65; x <= 97; x++)
                {
                    if (str1[i] == x)
                    {
                        chage = x + 32;
                        LOW += (char)chage;
                    }
                }
            }
            Console.Write(LOW);
            Console.WriteLine();
        }
    }
}
