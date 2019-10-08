using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintAlphabet();
           //Console.WriteLine();
           // PrintAlphabetUp();
           // Console.WriteLine();
           // PrintAlphabetB();
           // ASCIIcode('x');
            change('X');
        }
        public static void PrintAlphabet()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c);
            }            
        }
        public static void PrintAlphabetB()
        {
            for (char c = 'z'; c >= 'a'; c--)
            {
                Console.Write(c);
            }
        }
        public static void PrintAlphabetUp()
        {
            for (char c = 'A'; c <= 'Z';c++) 
            {
                Console.Write(c);
            }
        }
        public static void ASCIIcode(char c)
        {
            Console.WriteLine((int)c);
            //for (int i = 65; i <= 122; i++)
            //{
            //    if ((int)c == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
        public static void checkUPorLow(char c)
        {
            for (int i = 65; i <= 90; i++)
            {
                if ((int)c == i)
                {
                    Console.WriteLine("{0} is UPPERCASE", c);
                }
            }
            for (int j = 97; j <= 122; j++)
            {
                if ((int)c == j)
                {
                    Console.WriteLine("{0} is LOWERCASE", c);
                }
            }
        }
        public static void change(char c)
        {
           int chage = (int)c + 32;
           Console.Write((char)chage);
        }
        static int IsPalindrome(int number)
        {
            int temp, remainder, sum = 0;
            if (number <= 10)
            {
                Console.WriteLine("{0} not palindrome", number);
                return number;
            }
            for (temp = number; number != 0; number = number / 10)
            {
                remainder = number % 10;
                sum = sum * 10 + remainder;
            }
            if (temp == sum)
            {
                Console.WriteLine("{0} is palindrome", temp);
            }
            else
            {
                Console.WriteLine(" {0} not palindrome", temp);
            }
            return temp;
        }
    }
}
