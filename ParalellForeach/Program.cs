using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParalellForeach
{
    class Program
    {
        //Paralell Foreach: İçerisine almış olduğu bir arrayi ve bu array içerisindeki itemları
        //farklı threadlerda çalıştırarak multi thread kodlama yapmamızı sağlar.
        static void Main(string[] args)
        {
            string picturesPath = @"C:\Users\mertcan.elitas\Desktop\pic";

            var files = Directory.GetFiles(picturesPath);

             long longFiles = 0;

            Stopwatch sp = new Stopwatch();
            sp.Start();

            //Itemları parçalayıp işleri farklı threadlere vericek    ORNEK 1
            Parallel.ForEach(files, (item) =>
            {
                Console.WriteLine("Thread Id:" + Thread.CurrentThread.ManagedThreadId);
                Image img = new Bitmap(item);

                var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

                thumbnail.Save(Path.Combine(picturesPath, "thum", Path.GetFileName(item)));
            });

            //Interlocked classı sayesinde global olarak tanımladığımız bir değişkene    ORNEK 2
            //Farklı Threadlerin aynı anda ulaşıp hatalı sonuçlar oluşturmamasını sağlarız.
            //Race Condition Olarak adlandırılan Konu
            Parallel.ForEach(files, (item) =>
            {
                Console.WriteLine("Thread Id:" + Thread.CurrentThread.ManagedThreadId);

                FileInfo f = new FileInfo(item);

                //Interlocked classı sayesinde global olarak tanımladığımız bir değişkene
                //Farklı Threadlerin aynı anda ulaşıp hatalı sonuçlar oluşturmamasını sağlarız.
                //Race Condition Olarak adlandırılan Konu
                Interlocked.Add(ref longFiles, f.Length);
            });

            sp.Stop();

            Console.WriteLine("Zaman :" + sp.ElapsedMilliseconds);

            sp.Reset();

            sp.Start();
            //ORNEK 1 ile birlikte kullanıldı.
            files.ToList().ForEach(x =>
            {
                Console.WriteLine("Thread Id:" + Thread.CurrentThread.ManagedThreadId);
                Image img = new Bitmap(x);

                var thumbnail = img.GetThumbnailImage(50, 50, () => false, IntPtr.Zero);

                thumbnail.Save(Path.Combine(picturesPath, "thum", Path.GetFileName(x)));
            });


            sp.Stop();

            Console.WriteLine("Zaman :" + sp.ElapsedMilliseconds);
            Console.WriteLine("Sonuc:"+longFiles);
            Console.WriteLine("İşlem Bitti.");
            Console.ReadKey();
        }
    }
}
