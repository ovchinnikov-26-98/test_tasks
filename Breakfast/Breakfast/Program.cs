using System;
using System.Threading;
using System.Threading.Tasks;

namespace Breakfast
{
    class Program
    {
        static void CutMushRoom(int t)
        {
            Console.WriteLine("Cutting the mushroom.");
            Thread.Sleep(t * 1000);     //гриб режем синхронно
            Console.WriteLine("Cutting the mushroom finished.");
        }
        static async Task FryMushRoom(int t = 2)
        {
            Console.WriteLine("Frying the mushroom.");
            await Task.Delay(t * 1000);
            Console.WriteLine("Frying the mushroom finished.");
        }
        static async Task FryBreadSlices(int t)
        {
            Console.WriteLine("Frying bread slices.");
            await Task.Delay(t * 1000);
            Console.WriteLine("Frying bread slices finished.");

        }
        static async Task FryEggs(int t)
        {
            Console.WriteLine("Frying eggs.");
            await Task.Delay(t * 1000);
            Console.WriteLine("Frying eggs finished.");
        }
        static async Task MainAsync(string[] args)
        {
            Console.WriteLine("Start to cook breakfast!");
            CutMushRoom(5);
            Task t1 = FryMushRoom();
            Task t2 = FryBreadSlices(2);
            Task t3 = FryEggs(2);
            await Task.WhenAll(t1, t2, t3); //ожидание всех частей
            Console.WriteLine("Breakfast ready! Have a nice meal!");
        }
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
            Console.ReadKey();
        }
    }
}
