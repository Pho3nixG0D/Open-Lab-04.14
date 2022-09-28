using System;
using System.Linq;
using System.Xml.Linq;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {   
            //checking strings length
            int wordLength = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (wordLength < strings[i].Length)
                {
                    wordLength = strings[i].Length;
                }
            }
            // creating width of lines
            int width = 4 + wordLength;
            // firs row of "*"
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", width)));
            //writing lines with words
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("* ");
                Console.Write(strings[i]);
                for (int j = 0; j < width - strings[i].Length - 4; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }
            //last line "*"
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", width)));
        }
    }
}