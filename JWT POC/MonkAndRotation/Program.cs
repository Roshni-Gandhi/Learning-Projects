using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkAndRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the lenght of array and number of rotations in this format - L R");
            //string[] arrayDetails = Convert.ToString(Console.ReadLine()).Split();
            //int length = int.Parse(arrayDetails[0]);
            //int rotation = int.Parse(arrayDetails[1]);
            //Console.WriteLine("enter your array");
            //string[] arrayStr = Console.ReadLine().Split(' ');
            //int[] toRotate = new int[arrayStr.Length];
            //for (int i = 0; i < length; i++)
            //{
            //    toRotate[i] = Convert.ToInt32(arrayStr[i]);
            //}

            int length = 6;
            int rotation = 10;
            int[] toRotate = new int[] { 1, 2, 3, 4, 5, 6 };
            rotation = rotation % length;
            int[] result = new int[length];

            if (rotation > 0)
            {
                for (int i = 0; i < rotation; i++)
                {
                    result[i] = toRotate[length - (i+1)];
                } 
            }
            int remainingRotation = length - rotation;
            if (remainingRotation>0)
            {
                for (int i = 0; i < remainingRotation; i++)
                {
                    result[rotation +i] = toRotate[i];

                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();


        }
    }
}
