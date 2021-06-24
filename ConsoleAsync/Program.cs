using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAsync
{
    class Program
    {

        public static void CallBack(Task<string> data)
        {
            Console.WriteLine(data.Result.Length);
        }

        static void Main(string[] args)
        {

            //Deneme();
            StartNew();

            //TrainAsync();
            Console.ReadKey();
        }

        public static async Task Deneme()
        {
            Console.WriteLine("Current Main Thread:" + Thread.CurrentThread.ManagedThreadId);

            var urls = new List<string>()
            {
                "https://www.google.com",
                "https://www.amazon.com",
                "https://www.n11.com",
                "https://www.trendyol.com",
            };

            var list = new List<Task<Tuple<string, string>>>();
            urls.ForEach(x =>
            {
                var result = TrainWhenAllAsync(x);
                list.Add(result);
            });

            var allContents = await Task.WhenAll(list);

            foreach (var item in allContents)
            {
                Console.WriteLine($"Ad {item.Item1} Uzunluk {item.Item2}");
            }
        }

        public static async void TrainAsync()
        {
            Console.WriteLine("Hello World!");

            var result = await new HttpClient().GetStringAsync("https://www.google.com");

            Console.WriteLine("Callbackden Önce Çalıştım");

            Console.ReadKey();
        }

        //WhenAll Ornek

        public static async Task<Tuple<string, string>> TrainWhenAllAsync(string url)
        {
            var data = await new HttpClient().GetStringAsync(url);

            var result = new Tuple<string, string>(url, data.Length.ToString());

            Console.WriteLine("GetContent CurrentThread:" + Thread.CurrentThread.ManagedThreadId);

            return result;
        }

        public static async Task StartNew()
        {
            var myTask = Task.Factory.StartNew((data) =>
            {
                Console.WriteLine("myTask Çalıştı");
                var status = data as Status;

                status.ThreadId = Thread.CurrentThread.ManagedThreadId;
                status.Date = status.Date.AddDays(20);
            }, new Status() { Date = DateTime.Today }); ;

            await myTask;

            Status s = (Status)myTask.AsyncState;

            Console.WriteLine(s.Date);
            Console.WriteLine(s.ThreadId);
        }

    }

    public class Status
    {
        public int ThreadId { get; set; }
        public DateTime Date { get; set; }
    }
}
