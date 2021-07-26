using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            Task<Egg> eggTask = FryEggs(2);
            Task<Bacon> baconTask = FryBacon(3);
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2);

            Toast toast = await toastTask;
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("toast is ready");


            Egg egg = await eggTask;
            //FryEggs(2);
            Console.WriteLine("eggs are ready");
            Bacon bacon = await baconTask;

            //FryBacon(3);
            Console.WriteLine("bacon is ready");

            
            Console.WriteLine("Breakfast is ready!");
            Console.WriteLine(DateTime.Now); 
            Console.Read();
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private async static Task<Toast> ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private async static Task<Bacon> FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(5000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private async static Task<Egg> FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(5000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }

        private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBread(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }
    }
    class Coffee
    {    }

    class Egg
    {    }

    class Bacon
    {    }
    class Toast
    {    }
    class Juice
    {    }
}
