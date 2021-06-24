using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Count { get; set; } = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> data =  ReadDataAsync();

            var googleContent = await new HttpClient().GetStringAsync("https://www.google.com");

            richTxt2.Text =  googleContent;
            richtxt.Text = await data;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentCount = Count++.ToString();
            txtsayac.Text = currentCount;
        }

        private string ReadData()
        {
            using (StreamReader str=new StreamReader("metin.txt"))
            {
                var data = str.ReadToEnd();
                Thread.Sleep(5000);
                return data;
            }
        }

        private async Task<string> ReadDataAsync()
        {
            using (StreamReader str = new StreamReader("metin.txt"))
            {
                var data = await str.ReadToEndAsync();

               await Task.Delay(5000);

                 return data;
            }
        }

        private  Task<string> ReadDataAsync2()
        {
            //Bu kod bloğu hata verecektir.
            //Çünkü ReadToEndAsync methodu işlemini bitirmeden using
            //bloğundan çıkacağı için ve nesne dispose olacağı için hata fırlatır.
            using (StreamReader str = new StreamReader("metin.txt"))
            {
                var data =  str.ReadToEndAsync();
                return data;
            }
        }
    }
}
