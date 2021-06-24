using System;
using System.Diagnostics;
using System.Linq;

namespace PLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            var aaa = new[] { "Mertcan", "ali", "Veli" };

            var vv=aaa.AsParallel().Where(x => x[4] == 'a').ToList();

            var array = Enumerable.Range(1, 100);

            Stopwatch st = new Stopwatch();
            st.Start();

            var paralellArray = array.AsParallel().Where(x => x % 2 == 0).ToList();

            st.Stop();

            Console.WriteLine("Zaman 1:" + st.ElapsedMilliseconds);

            paralellArray.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            Console.ReadKey();
        }
    }
}
