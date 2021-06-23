using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{

    public class Program
    {

        public static void Main(string[] args)
        {
            FeatureFlag ffProvider = new FeatureFlag();
            BusinessClass businessClass = new BusinessClass(ffProvider);
            Task<bool> result = businessClass.DoSomething();
            result.Wait();
            Console.Read();
        }
    }
}

