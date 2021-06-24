using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sayi Giriniz:");
            var number = Convert.ToInt32(Console.ReadLine());

            var total = default(int);

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    total = total + i;
            }

            if (total == number)
                Console.WriteLine("Mükemmel Sayidir:" + number);
            else
                Console.WriteLine("Mükemmel Sayi Değildir:" + number);

            Console.ReadKey();
            //string picturesPath = @"C:\Users\mertcan.elitas\Desktop\pic";

            //var files = Directory.GetFiles(picturesPath);

            //long totalByte = 0;

            //Parallel.For(0, files.Length, (index) =>
            //  {
            //      var file = new FileInfo(files[index]);

            //      Interlocked.Add(ref totalByte, file.Length);

            //  });

            //Console.WriteLine("Total Byte:" + totalByte.ToString());
        }
    }
}
