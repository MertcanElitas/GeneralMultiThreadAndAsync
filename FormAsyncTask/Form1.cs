using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAsyncTask
{
    public partial class Form1 : Form
    {
        public static int Value { get; set; } = default(int);
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBaslat_Click(object sender, EventArgs e)
        {
            await StartProgress(progressBar1);
            await StartProgress(progressBar2);
        }

        public async Task StartProgress(ProgressBar bar)
        {
            await Task.Run(() =>
             {
                 Enumerable.Range(1, 100).ToList().ForEach(x =>
                 {
                     Thread.Sleep(100);

                     bar.Invoke((MethodInvoker)delegate { bar.Value = x; });
 
                     //bar.Value = x;
                 });
             });
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            btnArttir.Text = Value++.ToString();
        }
    }
}
