using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppAsync
{
    class Program
    {
        //WhenAll - WhenAny && WaitAll - WaitAny  methodları arasındaki fark wait ile başlayanlar mainthreadi(uithreadi) bloklar senkron çalıştırır. 
        //Task.Delay && Thread.Sleep()  methodları arasındaki fark Delay asenkron olarak işlem geciktirir mainthreadi bloklamaz.Sleep mainthreadi kitler senkron çalıştırır.
        static async Task Main(string[] args)
        {

            Console.WriteLine("Current Main Thread:" + Thread.CurrentThread.ManagedThreadId);

            var urls = new List<string>()
            {
                "https://www.google.com",
                "https://www.amazon.com",
                "https://www.n11.com",

            };

            var list = new List<Task<Tuple<string, string>>>();
            urls.ForEach(x =>
            {
                var result = TrainWhenAllAsync(x);
                list.Add(result);
            });

            //Console.WriteLine("WaitAll methodundan önce");
            //Task.WaitAll(list.ToArray());
            //Console.WriteLine("WaitAll methodundan sonra");

            var contents = await Task.WhenAll(list.ToArray());

            foreach (var item in contents)
            {
                Console.WriteLine($"Ad {item.Item1} Uzunluk {item.Item2}");
            }

            //foreach (var item in allContents)
            //{
            //    
            //}

            Console.ReadKey();
            //TrainAsync();
        }
        public static async Task Deneme()
        {

        }

        public static async void TrainAsync()
        {
            Console.WriteLine("Hello World!");

            var result = await new HttpClient().GetStringAsync("https://www.google.com");

            await Task.Delay(3000);

        }

        //WhenAll Ornek

        public static async Task<Tuple<string, string>> TrainWhenAllAsync(string url)
        {
            var data = await new HttpClient().GetStringAsync(url);

            var result = new Tuple<string, string>(url, data.Length.ToString());

            //await Task.Delay(3000);

            Thread.Sleep(10000);

            Console.WriteLine("GetContent CurrentThread:" + Thread.CurrentThread.ManagedThreadId);

            return result;
        }
    }
}
