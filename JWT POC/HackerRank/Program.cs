using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<int> arr, int number)
    {
        int result = 0;
        arr.Sort(); //nlogn
        result = CalculatePosition(0, arr.Count - 1, number, arr); //logn
        return result != -1 ? arr[result-1] : -1;
    }

    public static int CalculatePosition(int startIndex, int stopIndex, int numberToCheck, List<int> array)
    {

        if (startIndex < stopIndex)
        {
            int middle = (stopIndex + startIndex) / 2;
            if (array[middle] == numberToCheck)
            {
                return middle;
            }
            else if (numberToCheck > array[middle])
            {
                return CalculatePosition(middle + 1, stopIndex, numberToCheck, array);
            }
            else if (numberToCheck < array[middle])
            {
                return CalculatePosition(startIndex, middle - 1, numberToCheck, array);
            }
            else
            {
                return -1;
            }
        }
        else
        {
            return -1;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        ///List<int>> arr = new List<List<int>>();

        List<int> first = new List<int>();
        first.Add(-4);
        first.Add(3);
        first.Add(-9);
        first.Add(0);
        first.Add(4);
        first.Add(1);
        first.Add(3);
        first.Add(6);
        first.Add(7);
        first.Add(5);
        first.Add(8);
        first.Add(25);
        first.Add(12);
        first.Add(10);
        first.Add(56);
        first.Add(45);

        //int[] arr = new int[] {-4,3,-9,0,4,1,3,6,7,5,8,25,12,10,56,45 };

        Console.WriteLine("result is " + Result.diagonalDifference(first, 25));

        //Console.WriteLine(result);
        Console.Read();
        //Console.Flush();
        //Console.Close();
    }
}
