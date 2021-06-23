using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] node1 = new string[] { "hi", "hello", "how", "are", "you" };
            LinkedList<string> words = new LinkedList<string>(node1);
            //words.AddFirst("Hey");
            words.AddLast("Dhruv?");
            Display(words);
            Console.ReadLine();


        }

        private static void Display(LinkedList<string> linkedList)
        {
            foreach (string word in linkedList)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
