using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForeachRaceCon
{
    class Program
    {
        //Race Condition Orneğidir.Herzaman bu durum yaşanmayabilir.Ama farklı thread ler aynu
        //anda "değer" i set ettiğinden hatalı sonuçlar ortaya çıkabilir.
        static void Main(string[] args)
        {
            int deger = 0;

            Parallel.ForEach(Enumerable.Range(1, 10).ToList(), (item) =>
            {
                Interlocked.Add(ref deger, item);
                //deger = item;
            });

            Console.WriteLine("Hello World!"+deger);
            Console.ReadKey();
        }
    }
}
